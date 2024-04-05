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
        private const char openCharacter = '(';
        private const char closeCharacter = ')';
        private const char separatorCharacter = ' ';

        public static CookingOrder? Parse(string recipeText)
        {
            throw new NotImplementedException();
        }

        public static RecipeTree? TextToTree(string recipeText)
        {
            RecipeTree Root = new RecipeTree("");
            int OpenCount = 0;
            int CloseCount = 0;
            int LastSeparatorIndex = 0;
            for (int i = 0; (i < recipeText.Length) && (OpenCount + CloseCount >= 0); i++)
            {
                switch(recipeText[i])
                {
                    case CookingRecipeParser.openCharacter:
                        if (OpenCount == CloseCount) LastSeparatorIndex = i + 1;
                        OpenCount++;
                        break;
                    case CookingRecipeParser.closeCharacter:
                        CloseCount++;
                        if (OpenCount == CloseCount) Root.addSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                        break;
                    case CookingRecipeParser.separatorCharacter:
                        if (OpenCount == (CloseCount + 1))
                        {
                            Root.addSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                            LastSeparatorIndex = i + 1;
                        }
                        break;
                    default:
                        if (OpenCount == CloseCount) Root.token += recipeText[i];
                        break;
                }
            }
            return Root;
        }

        private static CookingOrder? TreeToOrder(RecipeTree recipeTree)
        {
            throw new NotImplementedException();
        }
    }
}
