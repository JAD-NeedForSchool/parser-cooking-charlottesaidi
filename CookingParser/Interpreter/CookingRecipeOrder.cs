using CookingParser.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Interpreter
{
    class CookingRecipeOrder
    {
        Ingredient.Ingredient ingredient { get; set; }

        public CookingRecipeOrder(Ingredient.Ingredient ingredient)
        {
            this.ingredient = ingredient;
        }
    }
}
