using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class RecipeTree
    {
        public string token {  get; set; }
        public List<RecipeTree> subRecipeTrees { get; set; }

        public RecipeTree(string token) 
        {
            this.token = token;
            this.subRecipeTrees = new List<RecipeTree>();
        }

        public void addSubRecipe(RecipeTree subRecipeTree)
        {
            if (this.subRecipeTrees == null)
            {
                this.subRecipeTrees = new List<RecipeTree>();
            }

            this.subRecipeTrees.Add(subRecipeTree);
        }
    }
}
