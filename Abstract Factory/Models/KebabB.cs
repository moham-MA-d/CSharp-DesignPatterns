using Abstract_Factory.Models.Base;

namespace Abstract_Factory.Models;

public class KebabB : ITraditionalFood
{
    public string GetFood()
    {
        return $"A {typeof(KebabB)} is ordered!";
    }
}