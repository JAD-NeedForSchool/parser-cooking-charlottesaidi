using CookingParser.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    abstract class CookingRecipeTokenHandler
    {
        public string token { get; set; }
        public CookingRecipeTokenHandler next { get; set; }

        public CookingRecipeTokenHandler(string token, CookingRecipeTokenHandler next)
        {
            this.token = token;
            this.next = next;
        }

        public CookingRecipeTokenHandler(string token)
        {
            this.token = token;
        }

        public bool HasNext()
        {
            return this.next != null;
        }

        public abstract CookingOrder Handle(Recipe recipe);
    }
}
