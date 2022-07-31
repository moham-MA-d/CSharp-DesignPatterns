using Memento.Models;

namespace Memento;

public class ShoppingCartState
{
    private Stack<Food> Foods { get; set; }= new();

    public ShoppingCartState(Stack<Food> foods)
    {
        Foods = foods;
    }
    public Stack<Food> GetFoods()
    {
        return Foods;
    }
}