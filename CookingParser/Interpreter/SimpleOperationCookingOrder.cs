using CookingParser.Operation.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Interpreter
{
    class SimpleOperationCookingOrder: CookingOrder
    {
        SimpleOperation operation { get; set; }

        void CookingOrder.Interpret(CookingRecipeOrder context)
        {
            Console.WriteLine("Cuisine en cours");
        }

        public SimpleOperationCookingOrder(SimpleOperation operation)
        {
            this.operation = operation;
        }
    }
}
