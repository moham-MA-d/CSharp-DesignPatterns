using Abstract_Factory.Models.Base;

namespace Abstract_Factory.Models;

public class PizzaA : IFastFood
{
    public string GetFood()
    {
        return $"A {typeof(PizzaA)} is ordered!";
    }
}