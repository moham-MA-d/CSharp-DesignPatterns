using Chain_Of_Responsibility.Helpers;
using Chain_Of_Responsibility.Models;

namespace Chain_Of_Responsibility.Handlers.RestaurantHandlers
{
    public class StarHandler : IReceiver<Order>
    {
        private StarRestaurantHelper StarRestaurantHelper { get; } = new ();
        public void Handle(Order order)
        {
            foreach (var food in order.OrderedFoods)
            {
                if (order.Restaurants.FirstOrDefault(x => x.RestaurantName == RestaurantName.Star)!
                    .AvailableFoods
                    .Any(x => x.Name == food.Name))
                {
                    StarRestaurantHelper.Finalize(order, food);
                }
            }
        }

        public void RestaurantHandle(Order order)
        {
            SetAvailableFoods(order);
        }

        private static void SetAvailableFoods(Order order)
        {
            var restaurant = new Restaurant(RestaurantName.Star);
            restaurant.AvailableFoods.Add(new Food(FoodsName.Pizza, 12, 1));
            restaurant.AvailableFoods.Add(new Food(FoodsName.Sandwich, 15, 2));
            order.Restaurants.Add(restaurant);
        }
    }
}
