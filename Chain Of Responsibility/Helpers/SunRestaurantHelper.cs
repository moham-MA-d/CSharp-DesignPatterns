using Chain_Of_Responsibility.Models;

namespace Chain_Of_Responsibility.Helpers
{
    public class SunRestaurantHelper : IHelper
    {
        public void Finalize(Order order, Food food)
        {
            if (food.IsPaid) return;
            
            var selectedFood = order.Restaurants
                .FirstOrDefault(x => x.RestaurantName == RestaurantName.Sun)!
                .AvailableFoods.FirstOrDefault(x => x.Name == food.Name);

            if (selectedFood != null && food.Price == selectedFood.Price) selectedFood.AvailableCount += -1;
            
            food.IsPaid = true;
            order.RegisteredFoods.Add(food);
        }
    }
}
