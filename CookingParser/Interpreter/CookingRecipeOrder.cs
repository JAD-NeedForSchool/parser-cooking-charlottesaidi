using CookingParser.Ingredient;
using CookingParser.Ingredient.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Interpreter
{
    class CookingRecipeOrder
    {
        public Ingredient.Ingredient ingredient { get; set; }

        public CookingRecipeOrder()
        {
            ingredient = new BasicIngredient("");
        }
    }
}
