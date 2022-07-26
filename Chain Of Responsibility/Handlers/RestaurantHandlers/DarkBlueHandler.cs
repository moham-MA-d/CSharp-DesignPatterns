using Chain_Of_Responsibility.Helpers;
using Chain_Of_Responsibility.Models;

namespace Chain_Of_Responsibility.Handlers.RestaurantHandlers
{
    public class DarkBlueHandler : IReceiver<Order>
    {
        private DarkBlueRestaurantHelper DarkBlueRestaurantHelper { get; } = new ();
        
        public void Handle(Order order)
        {
            foreach (var food in order.OrderedFoods)
            {
                if (order.Restaurants.FirstOrDefault(x => x.RestaurantName == RestaurantName.DarkBlue)!
                    .AvailableFoods
                    .Any(x => x.Name == food.Name))
                {
                    DarkBlueRestaurantHelper.Finalize(order, food);
                }
            }
        }

        public void RestaurantHandle(Order order)
        {
            SetAvailableFoods(order);
        }

        private static void SetAvailableFoods(Order order)
        {
            var restaurant = new Restaurant(RestaurantName.DarkBlue);
            restaurant.AvailableFoods.Add(new Food(FoodsName.Sandwich, 12, 2));
            restaurant.AvailableFoods.Add(new Food(FoodsName.Chicken, 15, 1));
            order.Restaurants.Add(restaurant);
        }
    }
}
