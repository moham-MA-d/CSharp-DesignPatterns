namespace Memento;

public class OrderStateHistory
{
    private readonly List<OrderState?> _states = new ();
    public void Push(OrderState? state) {
        _states.Add(state);
    }

    public OrderState? Pop() 
    {
        var last = _states.LastOrDefault();
        _states.Remove(last);
        
        return _states.LastOrDefault();
    }
}