namespace Strategy.Strategy.Cook;
public class SlowCookStrategy : ICookStrategy
{
    public string Cook()
    {
        return "Slow cook mode";
    }

    public int Price(int price)
    {
        return price + 10;
    }
}