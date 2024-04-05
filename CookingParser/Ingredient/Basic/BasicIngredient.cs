using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Ingredient.Basic
{
    abstract class BasicIngredient: Ingredient
    {
        public BasicIngredient(string name) : base(name)
        {
        }
    }
}
