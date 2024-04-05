using CookingParser.Interpreter;
using CookingParser.Operation.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class NaryOperationCookingOrderHandler: CookingRecipeTokenHandler
    {
        public string token {  get; set; }
        public NaryOperation operation { get; set; }

        public NaryOperationCookingOrderHandler(string token, NaryOperation operation): base(token)
        {
            this.operation = operation;
        }

        public override CookingOrder? Handle(Recipe recipe)
        {
            // todo
        }
    }
}
