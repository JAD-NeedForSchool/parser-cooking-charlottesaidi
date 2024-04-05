using CookingParser.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    abstract class CookingRecipeParser
    {
        public static string openCharacter { get; set; } = "(";
        public static string closeCharacter { get; set; } = ")";
        public static string separatorCharacter { get; set; } = "";

        public static CookingOrder? Parse(string recipeText)
        {
            throw new NotImplementedException();
        }

        private static RecipeTree? TextToTree(string recipeText)
        {
            throw new NotImplementedException();
        }

        private static CookingOrder? TreeToOrder(RecipeTree recipeTree)
        {
            throw new NotImplementedException();
        }
    }
}
