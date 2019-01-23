using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Recipe
    {
        private string name;
        private string[] ingredients;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string[] Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public Recipe()
        {

        }
    }
}
