using CookingParser.Operation.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Interpreter
{
    class NaryOperationCookingOrder: CookingOrder
    {
        NaryOperation[] operations { get; set; }
        void CookingOrder.Interpret(CookingRecipeOrder context)
        {
            Console.WriteLine("Cuisine en cours");
        }

        public NaryOperationCookingOrder(NaryOperation[] operations)
        {
            this.operations = operations;
        }
    }
}
