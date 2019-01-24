using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Color = System.Drawing.Color;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using WindowsFormsApp2;

/* TODO:
 * - If you have a bunch of time at some point, separate all utility functions to separate class
 * - Clean up code and comment
 * - Error handling when reading input files in case people add stuff that doesn't exist, or invalid formats.
 * - Exceptions for when items aren't selected for push to sheets/add to groceries
 * - Enable adding ingredients to recipe with comma as delimiter instead of spaces
 */

namespace GroceryApp
{
    public partial class mainWindow : Form
    {
        Dictionary<string, Dictionary<string, string>> recipes;
        SheetsService service;
        int grains = 0;
        int veg = 0;
        int dairy = 0;
        int protein = 0;
        int selectedDay = -1;
        int[,] weeklyValues = new int[7,4];
        int globalCount = 1;
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "super test";
        static string SheetId = "1kAifmTY7Dk0tw-kZPIG6zVCMV5jHEnL6dCBeJ2uoLQE";
        List<string>[] groceryList = new List<string>[7]
        {
            new List<string>(),
            new List<string>(),
            new List<string>(),
            new List<string>(),
            new List<string>(),
            new List<string>(),
            new List<string>()
        };
        Dictionary<string, string[]> ingredientList = new Dictionary<string, string[]>();

        ArrayList[] dailyRecipes = new ArrayList[7] 
        {
            new ArrayList(),
            new ArrayList(),
            new ArrayList(),
            new ArrayList(),
            new ArrayList(),
            new ArrayList(),
            new ArrayList(),
        };

        public mainWindow()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.exitApplication);
            recipeList.DoubleClick += new EventHandler(showRecipeIngredients);
            string json = File.ReadAllText("data.json");
            string ingredientsjson = File.ReadAllText("Recipe_Data.json");
            recipes = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            ingredientList = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(ingredientsjson);

            foreach (KeyValuePair<string, Dictionary<string, string>> item in recipes)
            {
                recipeList.Items.Add(item.Key);
            }          
        }

        private void addRecipeToDailyList(object sender, EventArgs e)
        {
            if(selectedDay > -1 && recipeList.SelectedItem != null)
            {
                string selection = recipeList.SelectedItem.ToString();
                grains = Int32.Parse(recipes[selection]["grains"]);
                veg = Int32.Parse(recipes[selection]["fruits & vegetables"]);
                dairy = Int32.Parse(recipes[selection]["dairy"]);
                protein = Int32.Parse(recipes[selection]["protein"]);

                ptotal.Text = (protein + Int32.Parse(ptotal.Text)).ToString();
                vtotal.Text = (veg + Int32.Parse(vtotal.Text)).ToString();
                dtotal.Text = (dairy + Int32.Parse(dtotal.Text)).ToString();
                gtotal.Text = (grains + Int32.Parse(gtotal.Text)).ToString();

                nutrientList.Items.Add(selection);
                dailyRecipes[selectedDay].Add(selection);
                weeklyValues[selectedDay, 0] = Int32.Parse(gtotal.Text);
                weeklyValues[selectedDay, 1] = Int32.Parse(vtotal.Text);
                weeklyValues[selectedDay, 2] = Int32.Parse(dtotal.Text);
                weeklyValues[selectedDay, 3] = Int32.Parse(ptotal.Text);
                checkDailyNutritionQuantities();
            }  
        }

        private void removeRecipeFromDailyList(object sender, EventArgs e)
        {
            if(selectedDay > -1 && nutrientList.SelectedItem != null)
            {
                string selection = nutrientList.SelectedItem.ToString();
                grains = Int32.Parse(recipes[selection]["grains"]);
                veg = Int32.Parse(recipes[selection]["fruits & vegetables"]);
                dairy = Int32.Parse(recipes[selection]["dairy"]);
                protein = Int32.Parse(recipes[selection]["protein"]);

                ptotal.Text = (Int32.Parse(ptotal.Text) - protein).ToString();
                vtotal.Text = (Int32.Parse(vtotal.Text) - veg).ToString();
                dtotal.Text = (Int32.Parse(dtotal.Text) - dairy).ToString();
                gtotal.Text = (Int32.Parse(gtotal.Text) - grains).ToString();

                weeklyValues[selectedDay, 0] -= grains;
                weeklyValues[selectedDay, 1] -= veg;
                weeklyValues[selectedDay, 2] -= dairy;
                weeklyValues[selectedDay, 3] -= protein;

                nutrientList.Items.Remove(selection);
                dailyRecipes[selectedDay].Remove(selection);
                checkDailyNutritionQuantities();
            }
        }

        private void exitApplication(object sender, EventArgs e)
        {
            using (StreamWriter file = File.CreateText(@"data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, recipes);
            }
            using (StreamWriter file = File.CreateText(@"Recipe_Data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, ingredientList);
            }
            Application.Exit();
        }

        private void checkDailyNutritionQuantities()
        {
            if (Int32.Parse(ptotal.Text) >= 3)
            {
                ptotal.ForeColor = Color.Green;
            }
            else
            {
                ptotal.ForeColor = Color.Red;
            }
            if (Int32.Parse(vtotal.Text) >= 8)
            {
                vtotal.ForeColor = Color.Green;
            }
            else
            {
                vtotal.ForeColor = Color.Red;
            }
            if (Int32.Parse(gtotal.Text) >= 8)
            {
                gtotal.ForeColor = Color.Green;
            }
            else
            {
                gtotal.ForeColor = Color.Red;
            }
            if (Int32.Parse(dtotal.Text) >= 2)
            {
                dtotal.ForeColor = Color.Green;
            }
            else
            {
                dtotal.ForeColor = Color.Red;
            }
        }

        private void addNewRecipeToMasterList(object sender, EventArgs e)
        {
            addRecipeForm newRecipeWindow = new addRecipeForm();

            if (newRecipeWindow.ShowDialog() == DialogResult.OK)
            {
                if(newRecipeWindow.isValid == true)
                {
                    Dictionary<string, string> newRecipe = new Dictionary<string, string>
                {
                    { "grains", newRecipeWindow.Grains },
                    { "fruits & vegetables", newRecipeWindow.Veg },
                    { "dairy", newRecipeWindow.Dairy },
                    { "protein", newRecipeWindow.Protein }
                };

                    recipes.Add(newRecipeWindow.RecipeName, newRecipe);
                    recipeList.Items.Add(newRecipeWindow.RecipeName);

                    ingredientList[newRecipeWindow.RecipeName] = newRecipeWindow.Ingredients;
                }               
            }
            newRecipeWindow.Close();
        }

        private void mondayButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            mondayButton.FlatStyle = FlatStyle.Standard;
            selectedDay = 0;
            nutrientList.Items.Clear();

            foreach(string item in dailyRecipes[0])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay,0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void tuesdayButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            tuesdayButton.FlatStyle = FlatStyle.Standard;
            selectedDay = 1;
            nutrientList.Items.Clear();

            foreach (string item in dailyRecipes[1])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay, 0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void wednesdayButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            wednesdayButton.FlatStyle = FlatStyle.Standard;
            selectedDay = 2;
            nutrientList.Items.Clear();

            foreach (string item in dailyRecipes[2])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay, 0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void thursdayButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            thursdayButton.FlatStyle = FlatStyle.Standard;
            selectedDay = 3;
            nutrientList.Items.Clear();

            foreach (string item in dailyRecipes[3])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay, 0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void fridayButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            fridayButton.FlatStyle = FlatStyle.Standard;
            selectedDay = 4;
            nutrientList.Items.Clear();

            foreach (string item in dailyRecipes[4])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay, 0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void saturdayButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            saturdayButton.FlatStyle = FlatStyle.Standard;
            selectedDay = 5;
            nutrientList.Items.Clear();

            foreach (string item in dailyRecipes[5])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay, 0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void sundayButton_Click(object sender, EventArgs e)
        {
            resetButtonColors();
            sundayButton.FlatStyle = FlatStyle.Standard;
            selectedDay = 6;
            nutrientList.Items.Clear();

            foreach (string item in dailyRecipes[6])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay, 0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void resetButtonColors()
        {
            sundayButton.FlatStyle = FlatStyle.System;
            mondayButton.FlatStyle = FlatStyle.System;
            tuesdayButton.FlatStyle = FlatStyle.System;
            wednesdayButton.FlatStyle = FlatStyle.System;
            thursdayButton.FlatStyle = FlatStyle.System;
            fridayButton.FlatStyle = FlatStyle.System;
            saturdayButton.FlatStyle = FlatStyle.System;
        }

        private void clearDailyData(object sender, EventArgs e)
        {
            if(selectedDay > -1)
            {
                weeklyValues[selectedDay, 0] = 0;
                weeklyValues[selectedDay, 1] = 0;
                weeklyValues[selectedDay, 2] = 0;
                weeklyValues[selectedDay, 3] = 0;

                dailyRecipes[selectedDay].Clear();
                groceryList[selectedDay].Clear();
                reset();
            } 
        }

        private void clearWeeklyData(object sender, EventArgs e)
        {
            if(selectedDay > -1)
            {
                for (int i = 0; i < 7; i++)
                {
                    weeklyValues[i, 0] = 0;
                    weeklyValues[i, 1] = 0;
                    weeklyValues[i, 2] = 0;
                    weeklyValues[i, 3] = 0;
                }
                for (int i = 0; i < 7; i++)
                {
                    selectedDay = i;
                    dailyRecipes[i].Clear();
                    groceryList[i].Clear();
                    reset();
                }

                

                
            } 
        }

        private void reset()
        {
            nutrientList.Items.Clear();
            nutrientList.Update();

            foreach (string item in dailyRecipes[selectedDay])
            {
                nutrientList.Items.Add(item);
            }

            gtotal.Text = (weeklyValues[selectedDay, 0]).ToString();
            vtotal.Text = (weeklyValues[selectedDay, 1]).ToString();
            dtotal.Text = (weeklyValues[selectedDay, 2]).ToString();
            ptotal.Text = (weeklyValues[selectedDay, 3]).ToString();

            checkDailyNutritionQuantities();
        }

        private void exportDataToTextFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text documents(.txt)| *.txt";
            saveFileDialog1.Title = "Save your weekly stats";
            DateTime baseDate = DateTime.Today;
            DateTime thisWeekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);
            var startweek = thisWeekStart.ToString("dd-MM-yyyy");
            var thisWeekEnd = thisWeekStart.AddDays(6).ToString("dd-MM-yyyy");
            saveFileDialog1.FileName = startweek + " - " + thisWeekEnd;
            

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "" && saveFileDialog1.FileName != null)
            {
                using (StreamWriter file = File.CreateText(saveFileDialog1.FileName))
                {
                    string outputdata = condenseData();
                    file.Write(outputdata); 
                }   
            }
        }

        private void importDataFromTextFile(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    interpretData(fileContent);
                    MessageBox.Show("Opened weekly data from file: " + filePath);
                }
            } 
        }

        private string condenseData()
        {
            string bigOlText = "";

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bigOlText += weeklyValues[i, j] + " ";
                }
                bigOlText += "\n";
            }

            foreach (ArrayList list in dailyRecipes)
            {
                foreach(string item in list)
                {
                    bigOlText += item + ",";
                }
                bigOlText = bigOlText.Remove(bigOlText.Length - 1);
                bigOlText += "\n";
            }
            return bigOlText;
        }

        private void interpretData(string data)
        {
            for (int i = 0; i < 7; i++)
            {
                weeklyValues[i, 0] = 0;
                weeklyValues[i, 1] = 0;
                weeklyValues[i, 2] = 0;
                weeklyValues[i, 3] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                selectedDay = i;
                dailyRecipes[i].Clear();
                reset();
            }

            int linecount = 0;

            List<string> splitstring = data.Split('\n').ToList();
            foreach(string line in splitstring)
            {
                if (linecount < 7)
                {
                    var args = line.Split();
                    weeklyValues[linecount, 0] = Int32.Parse(args[0]);
                    weeklyValues[linecount, 1] = Int32.Parse(args[1]);
                    weeklyValues[linecount, 2] = Int32.Parse(args[2]);
                    weeklyValues[linecount, 3] = Int32.Parse(args[3]);
                    linecount++;                   
                }
                else
                {
                    List<string> splitline = line.Split(',').ToList();
                    foreach(string item in splitline)
                    {
                        if (item != "")
                        {
                            dailyRecipes[linecount - 7].Add(item);
                        }
                    }
                    linecount++; 
                }   
            }
            nutrientList.Update();
            resetButtonColors();           
        }

        private void removeRecipeFromMasterList(object sender, EventArgs e)
        {
            if(recipeList.SelectedItem != null)
            {
                string item = recipeList.SelectedItem.ToString();
                recipes.Remove(item);
                recipeList.Items.Clear();

                foreach (KeyValuePair<string, Dictionary<string, string>> recipe in recipes)
                {
                    recipeList.Items.Add(recipe.Key);
                }
                MessageBox.Show(item + " removed from recipe list");
            }
        }

        private void showRecipeIngredients(object sender, EventArgs e)
        {
            if (recipeList.SelectedItem != null)
            {
                string result = recipeList.SelectedItem.ToString() + "\n";
                foreach (var ingredient in ingredientList[recipeList.SelectedItem.ToString()])
                {
                    result += ingredient + "\n";
                }
    
                MessageBox.Show(result);
            }
        }

        private void sendDataToGoogleSpreadsheets(object sender, EventArgs e)
        {
            UserCredential credential;

            waitwindow f = new waitwindow();
            f.Show();

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None).Result;
            }

            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            String spreadsheetId = SheetId;
            String range = "A:A";

            SpreadsheetsResource.ValuesResource.GetRequest getRequest =
                       service.Spreadsheets.Values.Get(spreadsheetId, range);

            ValueRange getResponse = getRequest.Execute();
            IList<IList<Object>> getValues = getResponse.Values;
            List<List<object>> data = new List<List<object>>();
            int currentCount = getValues.Count() + 2;
            String newRange = "A" + currentCount + ":A";
            List<ValueRange> info = new List<ValueRange>();
            int count = 3;
            char cell = 'A';
   
            foreach (var recipe in groceryList)
            {
                var reciperange = new ValueRange();
                reciperange.Range = Char.ToString(cell) + count.ToString();
                reciperange.MajorDimension = "COLUMNS"; 
                List<object> ingreds = new List<object>();
                foreach (var x in recipe)
                {
                    string y = x.Substring(0, x.Length - 1);
                    ingreds.Add("----" + y + "----");
                    foreach (var item in ingredientList[x])
                    {
                        ingreds.Add(item);
                    }
                    ingreds.Add("");                    
                }
                reciperange.Values = new List<IList<object>> { ingreds };
                info.Add(reciperange);
                cell++;                
            }

            string valueInputOption = "USER_ENTERED";
            
            Google.Apis.Sheets.v4.Data.ClearValuesRequest yeah = new ClearValuesRequest();
            SpreadsheetsResource.ValuesResource.ClearRequest clear = service.Spreadsheets.Values.Clear(yeah, spreadsheetId, "A1:G50");
            clear.Execute();
            BatchUpdateValuesRequest requestBody = new BatchUpdateValuesRequest();
            requestBody.ValueInputOption = valueInputOption;
            requestBody.Data = info;
            SpreadsheetsResource.ValuesResource.BatchUpdateRequest request = service.Spreadsheets.Values.BatchUpdate(requestBody, spreadsheetId);
            BatchUpdateValuesResponse response = request.Execute();

            var headerRange = new ValueRange();
            List<object> hd = new List<object>();
            hd.Add("Monday");
            hd.Add("Tuesday");
            hd.Add("Wednesday");
            hd.Add("Thursday");
            hd.Add("Friday");
            hd.Add("Saturday");
            hd.Add("Sunday");
            headerRange.Range = "A1:G1";
            headerRange.Values = new List<IList<object>> { hd };
            List<ValueRange> headerinfo = new List<ValueRange>();
            headerinfo.Add(headerRange);
            BatchUpdateValuesRequest requestBody2 = new BatchUpdateValuesRequest();
            requestBody2.ValueInputOption = valueInputOption;
            requestBody2.Data = headerinfo;
            SpreadsheetsResource.ValuesResource.BatchUpdateRequest request2 = service.Spreadsheets.Values.BatchUpdate(requestBody2, spreadsheetId);
            BatchUpdateValuesResponse response2 = request2.Execute();
            f.Close();
            MessageBox.Show("Grocery Info Sent to Google Spreadsheet.");
        }
        private void addIngredientsToGroceryList(object sender, EventArgs e)
        {           
            if(nutrientList.SelectedItem != null)
            {
                Recipe recipe = new Recipe();
                recipe.Name = nutrientList.SelectedItem.ToString();
                recipe.Ingredients = ingredientList[nutrientList.SelectedItem.ToString()];
                IngredientForm ingredientForm = new IngredientForm(recipe);

                if (ingredientForm.ShowDialog() == DialogResult.OK)
                {
                    if (ingredientForm.isValid == true)
                    {
                        groceryList[selectedDay].Add(nutrientList.SelectedItem.ToString() + globalCount.ToString());
                        ingredientList[nutrientList.SelectedItem.ToString() + globalCount.ToString()] = ingredientForm.ConfirmedIngredients;
                        globalCount++;
                        ingredientForm.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe from added list.");
            }
            
        }
    }    
}

