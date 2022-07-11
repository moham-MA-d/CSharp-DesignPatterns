using Abstract_Factory.Models.Base;

namespace Abstract_Factory.Models;

public class RestaurantA : IRestaurant
{
    public IFastFood GetFastFood()
    {
        Console.WriteLine($"{nameof(RestaurantA)} serving a FastFood: {nameof(PizzaA)}...");
        return new PizzaA();
    }

    public ITraditionalFood GetTraditionalFood()
    {
        Console.WriteLine($"{nameof(RestaurantA)} serving a TraditionalFood: {nameof(KebabA)}...");
        return new KebabA();
    }

}