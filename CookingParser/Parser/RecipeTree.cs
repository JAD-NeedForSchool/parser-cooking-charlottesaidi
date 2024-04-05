using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class Recipe
    {
        public string token {  get; set; }

        public Recipe(string token) 
        {
            this.token = token;
        }
    }
}
