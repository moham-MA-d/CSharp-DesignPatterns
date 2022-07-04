using Flyweight.FlyweightInterface;

namespace Flyweight.FlyweightClasses;

public class Kebab : IFoodFlyweight
{
    private readonly string _title;
    public string Title { get { return _title; } }

    private readonly IEnumerable<string> _ingredients;

    public Kebab()
    {
        _title = "Persian Kebab";
        _ingredients = new List<string>()
        {
            "Meat",
            "Tomato"
        };
    }

    public void Cook(string type)
    {
        Console.WriteLine($"- {type} {_title} with {string.Join(", ", _ingredients)} is coming up!");
    }

}

