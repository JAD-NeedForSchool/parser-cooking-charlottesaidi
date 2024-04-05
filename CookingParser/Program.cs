using CookingParser.Ingredient.Basic;
using CookingParser.Interpreter;
using CookingParser.Operation.Complex;
using CookingParser.Operation.Simple;
using CookingParser.Parser;

CookingOrder TakeYellowOrder = new SimpleOperationCookingOrder(new SimpleOperation("PrendreJaune"), new IngredientCookingOrder(new BasicIngredient("Oeuf")));
CookingRecipeOrder context = new CookingRecipeOrder();



CookingOrder MixOrder = new NaryOperationCookingOrder(new NaryOperation("Mélanger"), [
        TakeYellowOrder,
    new IngredientCookingOrder(new BasicIngredient("Moutarde")),
    new IngredientCookingOrder(new BasicIngredient("Vinaigre")),
]);

CookingOrder AddOrder = new NaryOperationCookingOrder(new NaryOperation("Ajouter"), [
        MixOrder,
    new IngredientCookingOrder(new BasicIngredient("Huile")),
]);
CookingOrder MayonnaiseRecipe = new SimpleOperationCookingOrder(new SimpleOperation("Touiller"), AddOrder);

CookingRecipeOrder MayonnaiseOrder = new CookingRecipeOrder();

MayonnaiseRecipe.Interprete(MayonnaiseOrder);

Console.WriteLine(MayonnaiseOrder.ingredient.name);

string recipeText = "Touiller(Ajouter(Mélanger(PrendreJaune(Oeuf) Moutarde Vinaigre ) Huile ))";
RecipeTree recipeTree = CookingRecipeParser.TextToTree(recipeText);

Console.WriteLine("Recipe Tree:");
CookingRecipeParser.PrintRecipeTree(recipeTree, 0);