Type foodType = GetFoodType();

MainIngredient ingredient = GetIngredient();

Seasoning seasoning = GetSeasoning();

DisplayResults(foodType, ingredient, seasoning);

Type GetFoodType()
{
    int foodChoice;

    Console.Write("""
                  Make a selection for the Food Type:
                  1. Soup
                  2. Stew
                  3. Gumbo

                  Selection: 
                  """);
    do
    {
        foodChoice = UserInput();
    } while (foodChoice < 1 || foodChoice > 3);

    return foodChoice switch
    {
        1 => Type.Soup,
        2 => Type.Stew,
        3 => Type.Gumbo
    };
}

MainIngredient GetIngredient()
{
    int ingredientChoice;

    Console.Clear();
    Console.Write("""
                  Make a selection for the Ingredient Type:
                  1. Mushroom
                  2. Chicken
                  3. Carrot
                  4. Potatoes

                  Selection:
                  """);
    do
    {
        ingredientChoice = UserInput();
    } while (ingredientChoice < 1 || ingredientChoice > 4);

    return ingredientChoice switch
    {
        1 => MainIngredient.Mushroom,
        2 => MainIngredient.Chicken,
        3 => MainIngredient.Carrot,
        4 => MainIngredient.Potato
    };
}

Seasoning GetSeasoning()
{
    int seasoningChoice;

    Console.Clear();
    Console.Write("""
                  Make a selection for the Season Type:
                  1. Spicy
                  2. Salty
                  3. Sweet

                  Selection:
                  """);
    do
    {
        seasoningChoice = UserInput();
    } while (seasoningChoice < 1 || seasoningChoice > 3);

    return seasoningChoice switch
    {
        1 => Seasoning.Spicy,
        2 => Seasoning.Salty,
        3 => Seasoning.Sweet
    };
}

void DisplayResults(Type foodChoice, MainIngredient ingredientChoice, Seasoning seasoningChoice)
{
    var results = (FoodType: foodChoice, Ingredient: ingredientChoice, Seasoning: seasoningChoice);

    Console.Clear();
    Console.Write($"Today's menu is {results.Seasoning} {results.Ingredient} {results.FoodType}");
}

int UserInput()
{
    return Convert.ToInt32(Console.ReadLine());
}

enum Type
{
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Mushroom,
    Chicken,
    Carrot,
    Potato
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}