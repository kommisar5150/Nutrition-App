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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, Dictionary<string, string>> recipes;
        int grains = 0;
        int veg = 0;
        int dairy = 0;
        int protein = 0;
        int[][] weeklyValues;

        public Form1()
        {
            InitializeComponent();
            string json = File.ReadAllText("data.json");
            recipes = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            foreach (KeyValuePair<string, Dictionary<string, string>> item in recipes)
            {
                recipeList.Items.Add(item.Key);
            }
        }

        private void addRecipe_Click(object sender, EventArgs e)
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
            checkQuantities();


        }

        private void removeRecipe_Click(object sender, EventArgs e)
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

            nutrientList.Items.Remove(selection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkQuantities()
        {
            if (Int32.Parse(ptotal.Text) >= 3)
            {
                ptotal.ForeColor = Color.Green;
            }
            if (Int32.Parse(vtotal.Text) >= 8)
            {
                vtotal.ForeColor = Color.Green;
            }
            if (Int32.Parse(gtotal.Text) >= 8)
            {
                gtotal.ForeColor = Color.Green;
            }
            if (Int32.Parse(dtotal.Text) >= 2)
            {
                dtotal.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRecipeForm newRecipeWindow = new addRecipeForm();
            

            if (newRecipeWindow.ShowDialog() == DialogResult.OK)
            {
                string[] values = newRecipeWindow.getValues();
                string n = values[0];
                string g = values[1];
                string v = values[2];
                string d = values[3];
                string p = values[4];

                Dictionary<string, string> newRecipe = new Dictionary<string, string>
                {
                    { "grains", newRecipeWindow.Grains },
                    { "fruits & vegetables", newRecipeWindow.Veg },
                    { "dairy", newRecipeWindow.Dairy },
                    { "protein", newRecipeWindow.Protein }
                };

                recipes.Add(newRecipeWindow.RecipeName, newRecipe);
                recipeList.Items.Add(newRecipeWindow.RecipeName);

                newRecipeWindow.Close();
            }
        }
    }
}
