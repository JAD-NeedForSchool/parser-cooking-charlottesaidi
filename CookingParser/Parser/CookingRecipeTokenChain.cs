using CookingParser.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class CookingRecipeTokenChain: CookingRecipeTokenHandler
    {
        static CookingRecipeTokenChain instance {  get; set; } = new CookingRecipeTokenChain();

        CookingRecipeTokenChain(): base("")
        { }

        public CookingRecipeTokenChain getInstance() { 
            return CookingRecipeTokenChain.instance; 
        }

        public override CookingOrder? Handle(RecipeTree recipe)
        {
            if (this.next != null)
            {
                this.next.Handle(recipe);
            }

            return null;
        }
    }
}
