using Abstract_Factory.Models.Base;

namespace Abstract_Factory.Models;

public class KebabA : ITraditionalFood
{
    public string GetFood()
    {
        return $"A {typeof(KebabA)} is ordered!";
    }
}