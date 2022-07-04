using Flyweight.FlyweightClasses;
using Flyweight.FlyweightInterface;
using Flyweight.NonFlyweightClasses;

namespace Flyweight;

public class FoodFactory
{
    private readonly Dictionary<string, IFoodFlyweight> _foodCache = new();

    public int ObjectsCreated = 0;

    public IFoodFlyweight GetFood(string foodKey)
    {

        if (_foodCache.ContainsKey(foodKey))
        {
            Console.WriteLine("\n Reusing existing flyweight object.");
            return _foodCache[foodKey];
        }

        Console.WriteLine("\n Creating new flyweight object.");

        IFoodFlyweight food = foodKey switch
        {
            "Kebab" => new Kebab(),
            "Sandwich" => new Sandwich(),
            _ => throw new Exception("This is not a flyweight food object."),
        };

        _foodCache.Add(foodKey, food);
        ObjectsCreated++;

        return food;
    }

    public void ListFoods()
    {
        Console.WriteLine($"Number of objects created: {ObjectsCreated}");
        Console.WriteLine($"\n Factory has {_foodCache.Count} food objects ready to use.");

        foreach (var food in _foodCache)
            Console.WriteLine($"\t {food.Value.Title}");

        Console.WriteLine("\n");
    }

    public static IFoodFlyweight CreateGiveaway()
    {
        return new GiveawayFoods();
    }
}
