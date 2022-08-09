using Strategy.Strategy.Cook;
using Strategy.Strategy.Payment;

namespace Strategy.Models;

public class Kebab : Food
{
    public override void Cook(ICookStrategy cookStrategy, IPaymentStrategy paymentStrategy)
    {
        Console.WriteLine($"A Kebab is cooking in {cookStrategy.Cook()} with Price: {cookStrategy.Price(Price)}");
    }

}