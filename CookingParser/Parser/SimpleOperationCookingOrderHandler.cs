using CookingParser.Interpreter;
using CookingParser.Operation.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class SimpleOperationCookingOrderHandler: CookingRecipeTokenHandler
    {
        public string token {  get; set; }
        public SimpleOperation operation { get; set; }

        public SimpleOperationCookingOrderHandler(string token, SimpleOperation operation): base(token)
        {
            this.operation = operation;
        }

        public override CookingOrder Handle(Recipe recipe)
        {
            // todo
        }
    }
}
