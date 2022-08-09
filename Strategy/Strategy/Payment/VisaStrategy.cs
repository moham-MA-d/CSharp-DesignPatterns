namespace Strategy.Strategy.Payment;

public class VisaStrategy : IPaymentStrategy
{
    public string Payment()
    {
        return "MasterCard";
    }
}