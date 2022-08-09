namespace Strategy.Strategy.Payment;

public class MasterCardStrategy : IPaymentStrategy
{
    public string Payment()
    {
        return "Visa";
    }
}