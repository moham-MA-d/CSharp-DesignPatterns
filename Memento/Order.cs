namespace Memento;

public class Order
{
    private string FoodName { get; set; }

    public void CreateOrder(string foodName)
    {
        FoodName = foodName;
    }
    public string GetOrder()
    {
        return FoodName;
    }


    public OrderState? CreateState()
    {
        return new OrderState(FoodName);
    }

    public void Undo(OrderState? state)
    {
        if (state != null) FoodName = state.GetOrder();
    }
    
    
}