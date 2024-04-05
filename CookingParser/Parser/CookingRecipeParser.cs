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
        private static readonly char openCharacter = '(';
        private static readonly char closeCharacter = ')';
        private static readonly char separatorCharacter = ' ';

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
                if (recipeText[i] == CookingRecipeParser.openCharacter)
                {
                    if (OpenCount == CloseCount) LastSeparatorIndex = i + 1;
                    OpenCount++;
                }
                else if (recipeText[i] == CookingRecipeParser.closeCharacter)
                {
                    CloseCount++;
                    if (OpenCount == CloseCount) Root.addSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                }
                else if (recipeText[i] == CookingRecipeParser.separatorCharacter)
                {
                    if (OpenCount == (CloseCount + 1))
                    {
                        Root.addSubRecipe(CookingRecipeParser.TextToTree(recipeText.Substring(LastSeparatorIndex, i - LastSeparatorIndex + 1)));
                        LastSeparatorIndex = i + 1;
                    }
                }
                else
                {
                    if (OpenCount == CloseCount) Root.token += recipeText[i];
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
