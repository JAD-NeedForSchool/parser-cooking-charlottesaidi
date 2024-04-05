using CookingParser.Interpreter;
using CookingParser.Operation.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Parser
{
    internal class NaryOperationCookingOrderHandler(string token, NaryOperation operation) : CookingRecipeTokenHandler
    {
        public string token { get; set; } = token;
        public NaryOperation operation { get; set; } = operation;

        public override CookingOrder Handle(Recipe recipe)
        {
            return new NaryOperationCookingOrder();
        }
    }
}
