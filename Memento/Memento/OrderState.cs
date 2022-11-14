namespace Memento.Memento;

public class OrderState
{
    private string Order { get; }

    public OrderState(string order)
    {
        Order = order;
    }
    public string GetOrder()
    {
        return Order;
    }
}