using Flyweight.FlyweightClasses;
using Flyweight.FlyweightInterface;

namespace Flyweight.NonFlyweightClasses;

public class FoodsGiveaway : IFoodFlyweight
{
    public string Title
    {
        get { return _randomFood.Title; }
    }

    private IFoodFlyweight[] _eligibleFoods = new IFoodFlyweight[] {
        new Kebab(),
        new Sandwich()
    };


    private IFoodFlyweight _randomFood;
    private string _type;
    public FoodsGiveaway()
    {
        var randomIndex = new Random().Next(0, 2);
        _randomFood = _eligibleFoods[randomIndex];
    }

    public void Cook(string type)
    {
        _type = type;
        Console.WriteLine($"Free Giveaway!");
        Console.WriteLine($"- {_type} {_randomFood.Title} is coming up! ");
    }
}

