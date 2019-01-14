using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addRecipeForm : Form
    {
        private string recipeName;
        private string grains;
        private string veg;
        private string dairy;
        private string protein;

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
            RecipeName = nameBox.Text;
            Grains = grainBox.Text;
            Veg = vegBox.Text;
            Dairy = dairyBox.Text;
            Protein = proteinBox.Text;
            MessageBox.Show("Recipe Added!");
        }
    }
}
