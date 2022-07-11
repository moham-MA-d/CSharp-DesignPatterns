using Abstract_Factory.Models.Base;

namespace Abstract_Factory.Models;

public class PizzaB : IFastFood
{
    public string GetFood()
    {
        return $"A {typeof(PizzaB)} is ordered!";
    }
}