using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class IngredientForm : Form
    {
        public Recipe recipe;
        private string[] confirmedIngredients;
        public bool isValid;

        public string[] ConfirmedIngredients
        {
            get { return confirmedIngredients; }
            set { confirmedIngredients = value; }
        }

        public IngredientForm(Recipe x)
        {
            InitializeComponent();
            this.recipe = x;
            
            foreach (var item in recipe.Ingredients)
            {
                ingredientList.Items.Add(item);
            }           
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            isValid = true;
            var y = ingredientList.CheckedItems;
            var x = y.GetEnumerator();
            var list = new List<string>();
            while (x.MoveNext())
                list.Add(x.Current.ToString());
            var array = list.ToArray();
            ConfirmedIngredients = array;

            if(confirmedIngredients.Length == 0)
            {
                isValid = false;
            }
        }
    }
}
