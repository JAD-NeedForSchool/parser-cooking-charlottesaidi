using CookingParser.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Interpreter
{
    class IngredientCookingOrder: CookingOrder
    {
        Ingredient.Ingredient ingredient { get; set; }
        public void Interpret(CookingRecipeOrder context)
        {
            Console.WriteLine("Cuisine en cours");
        }

        public IngredientCookingOrder(Ingredient.Ingredient ingredient)
        {
            this.ingredient = ingredient;
        }
    }
}
