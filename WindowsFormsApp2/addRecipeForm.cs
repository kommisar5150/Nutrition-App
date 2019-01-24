using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class addRecipeForm : Form
    {
        private string recipeName;
        private string grains;
        private string veg;
        private string dairy;
        private string protein;
        private string[] ingredients;
        public bool isValid;

        public string RecipeName
        {
            get { return recipeName; }
            set { recipeName = value; }
        }
        public string Grains
        {
            get { return grains; }
            set { grains = value; }
        }
        public string Veg
        {
            get { return veg; }
            set { veg = value; }
        }
        public string Dairy
        {
            get { return dairy; }
            set { dairy = value; }
        }
        public string Protein
        {
            get { return protein; }
            set { protein = value; }
        }
        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }


        public string[] getValues()
        {
            string[] values = { recipeName, grains, veg, dairy, protein };
            return values;
        }

        public addRecipeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(nameBox.Text != "" && grainBox.Text != "" && vegBox.Text != "" && dairyBox.Text != "" && proteinBox.Text != "")
            {
                RecipeName = nameBox.Text;
                Grains = grainBox.Text;
                Veg = vegBox.Text;
                Dairy = dairyBox.Text;
                Protein = proteinBox.Text;
                Ingredients = ingredientsBox.Text.Split();
                isValid = true;
                MessageBox.Show(nameBox.Text + " Recipe Added!");
            }
            else
            {
                isValid = false;
                MessageBox.Show("Some fields have been left empty! Fill in all blanks (0 if not applicable)");
            }
            
        }
    }
}
