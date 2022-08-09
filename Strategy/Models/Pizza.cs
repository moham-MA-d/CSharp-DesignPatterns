using Strategy.Strategy.Cook;
using Strategy.Strategy.Payment;

namespace Strategy.Models;

public class Pizza : Food
{
    public override void Cook(ICookStrategy cookStrategy, IPaymentStrategy paymentStrategy)
    {
        Console.WriteLine($"A Pizza is cooking in {cookStrategy.Cook()} with Price: {cookStrategy.Price(Price)}");
        Console.WriteLine($"Payment Method: {paymentStrategy.Payment()}");

    }
}