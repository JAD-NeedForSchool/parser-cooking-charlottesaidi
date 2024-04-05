using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Ingredient
{
    abstract class Ingredient
    {
        string Name { get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
