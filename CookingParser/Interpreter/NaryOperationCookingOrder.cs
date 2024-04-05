using CookingParser.Ingredient.Complex;
using CookingParser.Operation;
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
        public Operation.Operation operation { get; set; }
        public List<CookingOrder> cookingOrders { get; set; }
        void CookingOrder.Interprete(CookingRecipeOrder context)
        {
            String subIngredients = "";
            foreach (CookingOrder order in this.cookingOrders)
            {
                CookingRecipeOrder subContext = new CookingRecipeOrder();
                order.Interprete(subContext);
                subIngredients += subContext.ingredient.name + " ";
            }

            context.ingredient = new ComplexIngredient(this.operation.name + "(" + subIngredients + ")");
        }

        public NaryOperationCookingOrder(Operation.Operation operation, List<CookingOrder> cookingOrders)
        {
            this.operation = operation;
            this.cookingOrders = cookingOrders;
        }
    }
}
