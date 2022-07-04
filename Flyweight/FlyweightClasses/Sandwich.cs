using Flyweight.FlyweightInterface;

namespace Flyweight.FlyweightClasses;

public class Sandwich : IFoodFlyweight
{
    private readonly string _title;
    public string Title { get { return _title; } }

    private readonly IEnumerable<string> _ingredients;

    public Sandwich()
    {
        _title = "Meatball Sandwich";
        _ingredients = new List<string>()
        {
            "Meatball",
            "Sauce",
            "Cheese"
        };
    }

    public void Cook(string type)
    {
        Console.WriteLine($"- {type} {_title} with {string.Join(", ", _ingredients)} is coming up!");
    }

}

