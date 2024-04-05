using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class RecipeTree(string token)
    {
        public string token { get; set; } = token;
        public List<RecipeTree> subRecipeTrees { get; set; } = [];

        public void addSubRecipe(RecipeTree subRecipeTree)
        {
            this.subRecipeTrees.Add(subRecipeTree);
        }
    }
}
