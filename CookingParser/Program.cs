using CookingParser.Ingredient.Basic;
using CookingParser.Ingredient;
using CookingParser.Interpreter;
using CookingParser.Operation.Simple;

Ingredient egg = new Egg();

SimpleOperation cut = new Cut();

CookingRecipeOrder recipeOrder = new CookingRecipeOrder(egg);

CookingOrder order = new SimpleOperationCookingOrder(cut);

order.Interpret(recipeOrder);
