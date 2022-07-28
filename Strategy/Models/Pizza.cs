namespace Strategy.Models;

public class Pizza : Food
{
    public override void Cook()
    {
        Console.WriteLine($"A Pizza is cooking in {CookStrategy.Cook()} with Price: {CookStrategy.Price(Price)}");
    }
}