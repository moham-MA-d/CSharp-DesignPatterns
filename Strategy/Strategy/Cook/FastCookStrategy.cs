namespace Strategy.Strategy.Cook;

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