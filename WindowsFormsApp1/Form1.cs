﻿using System;
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

/* TODO:
 * - If you have a bunch of time at some point, separate all utility functions to separate class
 * - Clean up code and comment
 * - Error handling when reading input files in case people add stuff that doesn't exist, or invalid formats.
 * - New input/output handler format to handle multi-digit numbers
 */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Dictionary<string, string>> recipes;
        int grains = 0;
        int veg = 0;
        int dairy = 0;
        int protein = 0;
        int selectedDay = -1;
        int[,] weeklyValues = new int[7,4];

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

        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            string json = File.ReadAllText("data.json");
            recipes = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            foreach (KeyValuePair<string, Dictionary<string, string>> item in recipes)
            {
                recipeList.Items.Add(item.Key);
            }
        }

        private void addRecipe_Click(object sender, EventArgs e)
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
                checkQuantities();
            }  
        }

        private void removeRecipe_Click(object sender, EventArgs e)
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
                checkQuantities();
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            using (StreamWriter file = File.CreateText(@"data.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, recipes);
            }
            Application.Exit();
        }

        private void checkQuantities()
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

        private void button1_Click(object sender, EventArgs e)
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

            checkQuantities();
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

            checkQuantities();
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

            checkQuantities();
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

            checkQuantities();
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

            checkQuantities();
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

            checkQuantities();
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

            checkQuantities();
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

        private void button10_Click(object sender, EventArgs e)
        {
            if(selectedDay > -1)
            {
                weeklyValues[selectedDay, 0] = 0;
                weeklyValues[selectedDay, 1] = 0;
                weeklyValues[selectedDay, 2] = 0;
                weeklyValues[selectedDay, 3] = 0;

                dailyRecipes[selectedDay].Clear();
                reset();
            } 
        }

        private void button11_Click(object sender, EventArgs e)
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

            checkQuantities();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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
                    bigOlText += weeklyValues[i, j];
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
                    weeklyValues[linecount, 0] = (int)Char.GetNumericValue(line[0]);
                    weeklyValues[linecount, 1] = (int)Char.GetNumericValue(line[1]);
                    weeklyValues[linecount, 2] = (int)Char.GetNumericValue(line[2]);
                    weeklyValues[linecount, 3] = (int)Char.GetNumericValue(line[3]);
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

        private void button5_Click(object sender, EventArgs e)
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
                MessageBox.Show(item + "removed from recipe list");
            }
        }
    }
}
