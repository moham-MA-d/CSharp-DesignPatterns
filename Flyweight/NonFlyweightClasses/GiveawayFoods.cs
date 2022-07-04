using Flyweight.FlyweightClasses;
using Flyweight.FlyweightInterface;

namespace Flyweight.NonFlyweightClasses;

public class GiveawayFoods : IFoodFlyweight
{
    private string _type;
    public string Title { get { return _randomFood.Title; } }
    
    private readonly IFoodFlyweight _randomFood;
    
    private readonly IFoodFlyweight[] _eligibleFoods = new IFoodFlyweight[] {
        new Kebab(),
        new Sandwich()
    };

    public GiveawayFoods()
    {
        var randomIndex = new Random().Next(0, 2);
        _randomFood = _eligibleFoods[randomIndex];
    }

    public void Cook(string type)
    {
        _type = type;
        Console.WriteLine($"- {_type} {_randomFood.Title} is coming up! ");
    }
}

