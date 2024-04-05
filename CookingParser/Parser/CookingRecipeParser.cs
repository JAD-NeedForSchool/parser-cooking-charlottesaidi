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

        public static RecipeTree? TextToTree(string recipeText)
        {
            if (string.IsNullOrEmpty(recipeText)) 
            {
                return null;
            }

            Stack<RecipeTree> stack = new Stack<RecipeTree>();
            RecipeTree root = null;
            StringBuilder currentToken = new StringBuilder();

            for (int i = 0; i < recipeText.Length; i++)
            {
                char c = recipeText[i];

                if (c == CookingRecipeParser.openCharacter[0])
                {
                    if (currentToken.Length > 0)
                    {
                        RecipeTree newNode = new RecipeTree(currentToken.ToString());
                        if (stack.Count > 0)
                        {
                            stack.Peek().addSubRecipe(newNode);
                        }
                        else
                        {
                            root = newNode;
                        }
                        stack.Push(newNode);
                        currentToken.Clear();
                    }
                }
                else if (c == CookingRecipeParser.closeCharacter[0])
                {
                    if (currentToken.Length > 0)
                    {
                        stack.Peek().addSubRecipe(new RecipeTree(currentToken.ToString()));
                        currentToken.Clear();
                    }
                    stack.Pop();
                }
                else
                {
                    currentToken.Append(c);
                }
            }

            if (currentToken.Length > 0)
            {
                if (root == null)
                {
                    root = new RecipeTree(currentToken.ToString());
                }
                else
                {
                    stack.Peek().addSubRecipe(new RecipeTree(currentToken.ToString()));
                }
            }

            return root;
        }

        private static CookingOrder? TreeToOrder(RecipeTree recipeTree)
        {
            throw new NotImplementedException();
        }

        public static void PrintRecipeTree(RecipeTree node, int depth)
        {
            if (node == null)
                return;

            Console.WriteLine($"{new string(' ', depth * 2)}{node.token}");

            foreach (RecipeTree subNode in node.subRecipeTrees)
            {
                PrintRecipeTree(subNode, depth + 1);
            }
        }
    }
}
