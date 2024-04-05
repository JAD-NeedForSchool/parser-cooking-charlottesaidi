using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Ingredient
{
    abstract class Ingredient
    {
        public string name { get; set; }

        public Ingredient(string name)
        {
            this.name = name;
        }
    }
}
