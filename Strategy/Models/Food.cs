using Strategy.Strategy.Cook;
using Strategy.Strategy.Payment;

namespace Strategy.Models;

public abstract class Food
{
    public int Price { get; init; }
    public abstract void Cook(ICookStrategy cookStrategy, IPaymentStrategy paymentStrategy);
}
