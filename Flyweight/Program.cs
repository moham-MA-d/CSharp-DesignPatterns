using Flyweight;

var foodFactory = new FoodFactory();


Console.WriteLine("-------------- Flytweight Objects -------------");


foodFactory.GetFood("Kebab").Cook("Classic");
foodFactory.GetFood("Sandwich").Cook("Special");
foodFactory.GetFood("Kebab").Cook("Brand-made");


Console.WriteLine("-------------- Non-Flytweight Objects -------------");


var types = new string[] { "Classic", "Special", "Brand-made" };
foreach (var count in types)
{
    var giveaway = FoodFactory.CreateGiveaway();
    giveaway.Cook(count);
}


Console.WriteLine("-------------- List -------------");


foodFactory.ListFoods();
Console.ReadKey();