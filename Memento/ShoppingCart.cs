using Memento.Models;

namespace Memento;

public class ShoppingCart
{
    private Stack<Food> Foods { get; set; } = new();

    public void AddFood(Food food)
    {
        Foods.Push(food);
    }
    public Stack<Food> GetFoods()
    {
        return Foods;
    }


    public ShoppingCartState CreateState()
    {
        return new ShoppingCartState(Foods);
    }

    public void Restore(ShoppingCartState state)
    {
        Foods = state.GetFoods();
    }
    
    
}