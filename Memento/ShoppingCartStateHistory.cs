namespace Memento;

public class ShoppingCartStateHistory
{
    private readonly Stack<ShoppingCartState> _states = new ();
    public void Push(ShoppingCartState state) {
        _states.Push(state);
    }

    public ShoppingCartState Pop() 
    {
        var last =  _states.Pop();
        return last;
    }
}