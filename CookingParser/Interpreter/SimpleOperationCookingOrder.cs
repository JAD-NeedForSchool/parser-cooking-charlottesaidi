using CookingParser.Ingredient.Complex;
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
        public CookingOrder cookingOrder { get; set; }

        void CookingOrder.Interprete(CookingRecipeOrder context)
        {
            this.cookingOrder.Interprete(context);
            context.ingredient = new ComplexIngredient(this.operation.name + "(" + context.ingredient.name + ")");
        }

        public SimpleOperationCookingOrder(SimpleOperation operation, CookingOrder cookingOrder)
        {
            this.operation = operation;
            this.cookingOrder = cookingOrder;
        }
    }
}
