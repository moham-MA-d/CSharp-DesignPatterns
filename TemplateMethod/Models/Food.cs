using TemplateMethod.TemplateMethod;

namespace TemplateMethod.Models;

public abstract class Food
{
    private readonly Restaurant _restaurant;
    
    protected Food() { _restaurant = new Restaurant(); }
    protected Food(Restaurant restaurant)
    {
        _restaurant = restaurant;
    }

    public void Order()
    {
        _restaurant.OrderFood();
        
        PrepareIngredients();
        Cook();
        Decorate();
    }

    protected abstract void PrepareIngredients();
    protected abstract void Cook();
    protected abstract void Decorate();
    
}