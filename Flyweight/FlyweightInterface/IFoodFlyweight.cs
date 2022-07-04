namespace Flyweight.FlyweightInterface;

public interface IFoodFlyweight
{
    string Title { get; }
    void Cook(string type);
}

