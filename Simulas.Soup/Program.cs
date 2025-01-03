Type foodType = GetFoodType();

MainIngredient ingredient = GetIngredient();

Seasoning seasoning = GetSeasoning();

DisplayResults(foodType, ingredient, seasoning);

Type GetFoodType()
{
    Console.Write("""
                  Make a selection for the Food Type:
                  1. Soup
                  2. Stew
                  3. Gumbo

                  Selection: 
                  """);

    int foodChoice = UserInput(1, 3);

    return foodChoice switch
    {
        1 => Type.Soup,
        2 => Type.Stew,
        3 => Type.Gumbo
    };
}

MainIngredient GetIngredient()
{
    Console.Clear();
    Console.Write("""
                  Make a selection for the Ingredient Type:
                  1. Mushroom
                  2. Chicken
                  3. Carrot
                  4. Potatoes

                  Selection:
                  """);
    
    int ingredientChoice = UserInput(1, 4);

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
    Console.Clear();
    Console.Write("""
                  Make a selection for the Season Type:
                  1. Spicy
                  2. Salty
                  3. Sweet

                  Selection:
                  """);
    
    int seasoningChoice = UserInput(1, 3);

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

int UserInput(int firstChoice, int lastChoice)
{
    int validResponce = 0;

    do
    {
        validResponce = Convert.ToInt32(Console.ReadLine());        
    }while (validResponce < firstChoice || validResponce > lastChoice);

    return validResponce;
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