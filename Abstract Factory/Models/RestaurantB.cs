using Abstract_Factory.Models.Base;

namespace Abstract_Factory.Models;

public class RestaurantB : IRestaurant
{
    public IFastFood GetFastFood()
    {
        Console.WriteLine($"{nameof(RestaurantB)} serving a FastFood: {nameof(PizzaB)}...");
        return new PizzaB();
    }

    public ITraditionalFood GetTraditionalFood()
    {
        Console.WriteLine($"{nameof(RestaurantB)} serving a TraditionalFood: {nameof(KebabB)}...");
        return new KebabB();
    }
}