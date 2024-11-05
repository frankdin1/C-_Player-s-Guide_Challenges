// See https://aka.ms/new-console-template for more information
soupType liquidMeal = soupType.soup;
mainIngredient ingredient = mainIngredient.mushrooms;
seasoning seasoning = seasoning.spicy;

//tuple for user selected meal
(string mealType, string userIngredient, string userSeasoning) meal = ("", "", "");

Console.WriteLine("Select your meal from the menu options:");
Console.WriteLine("Menu");
Console.WriteLine("Type");
foreach (var i in Enum.GetValues(typeof(soupType))) //list of types of soups
    Console.WriteLine(i);

Console.WriteLine();

Console.WriteLine("Main ingredient");
foreach (var i in Enum.GetValues(typeof(mainIngredient))) //list of types of main ingredients
    Console.WriteLine(i);

Console.WriteLine();

Console.WriteLine("Seasoning");
foreach (var i in Enum.GetValues(typeof(seasoning))) //list of different seasonings
    Console.WriteLine(i);
Console.WriteLine();

Console.Write("Type: ");
string userType = Console.ReadLine();
meal.mealType = userType;

Console.Write("Main ingredient: ");
string userMainIngredient = Console.ReadLine();
meal.userIngredient = userMainIngredient;

Console.Write("Seasoning: ");
string userSeasoning = Console.ReadLine();
meal.userSeasoning = userSeasoning;

Console.WriteLine(meal);

//enums for the different parts of the meal
enum soupType
{
    soup,
    stew,
    gumbo
}

enum mainIngredient
{
    mushrooms,
    chicken,
    carrots,
    potatoes
}

enum seasoning
{
    spicy,
    salty,
    sweet
}