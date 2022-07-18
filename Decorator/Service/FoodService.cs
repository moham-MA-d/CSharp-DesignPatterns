using Decorator.Models;

namespace Decorator.Service;

public class FoodService : IFoodService
{
    public IEnumerable<Food> GetFoods()
    {
        var foods = new List<Food>
        {
            new Food() {Name = "Pizza", Price = 20},
            new Food() {Name = "Sandwich", Price = 12},
            new Food() {Name = "Kebab", Price = 25},
            new Food() {Name = "Chicken", Price = 15}
        };

        Thread.Sleep(1000);
        return foods;
    }
}