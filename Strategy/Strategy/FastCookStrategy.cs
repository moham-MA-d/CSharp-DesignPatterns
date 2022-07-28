using Strategy.Models;

namespace Strategy.Strategy;

public class FastCookStrategy : ICookStrategy
{
    public string Cook()
    {
        return "Fast cook mode";
    }

    public int Price(int price)
    {
        return price + 5;
    }
}