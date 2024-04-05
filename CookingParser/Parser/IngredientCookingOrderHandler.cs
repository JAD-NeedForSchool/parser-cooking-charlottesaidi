using CookingParser.Ingredient;
using CookingParser.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class IngredientCookingOrderHandler: CookingRecipeTokenHandler
    {
        public string token {  get; set; }
        public Ingredient.Ingredient ingredient { get; set; }

        public IngredientCookingOrderHandler(string token, Ingredient.Ingredient ingredient): base(token)
        {
            this.ingredient = ingredient;
        }

        public override CookingOrder? Handle(Recipe recipe)
        {
            // todo
        }
    }
}
