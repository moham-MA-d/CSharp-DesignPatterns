using Chain_Of_Responsibility.Helpers;
using Chain_Of_Responsibility.Models;

namespace Chain_Of_Responsibility.Handlers.RestaurantHandlers
{
    public class SunHandler : IReceiver<Order>
    {
        private SunRestaurantHelper SunRestaurantHelper { get; } = new();
        public void Handle(Order order)
        {
            foreach (var food in order.OrderedFoods)
            {
                if (order.Restaurants.FirstOrDefault(x => x.RestaurantName == RestaurantName.Sun)!
                    .AvailableFoods
                    .Any(x => x.Name == food.Name))
                {
                    SunRestaurantHelper.Finalize(order, food);
                }
            }
        }

        public void RestaurantHandle(Order order)
        {
            SetAvailableFoods(order);
        }

        private static void SetAvailableFoods(Order order)
        {
            var restaurant = new Restaurant(RestaurantName.Sun);
            restaurant.AvailableFoods.Add(new Food(FoodsName.Pizza, 20, 1));
            restaurant.AvailableFoods.Add(new Food(FoodsName.Kebab, 25, 2));
            order.Restaurants.Add(restaurant);
        }
    }
}
