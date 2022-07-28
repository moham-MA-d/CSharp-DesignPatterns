namespace Strategy.Models;

public class Kebab : Food
{
    public override void Cook()
    {
        Console.WriteLine($"A Kebab is cooking in {CookStrategy.Cook()} with Price: {CookStrategy.Price(Price)}");
    }
}