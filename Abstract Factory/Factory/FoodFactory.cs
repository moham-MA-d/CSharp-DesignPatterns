using Abstract_Factory.Enum;
using Abstract_Factory.Models;
using Abstract_Factory.Models.Base;

namespace Abstract_Factory.Factory;

public static class FoodFactory
{
    public static IRestaurant CreateFoodFactory(FoodOrderTypeEnum foodOrderTypeEnum)
    {
        IRestaurant restaurant = foodOrderTypeEnum switch
        {
            FoodOrderTypeEnum.DineIn => new RestaurantA(),
            FoodOrderTypeEnum.TakeAway => new RestaurantB(),
            _ => throw new ArgumentOutOfRangeException(nameof(foodOrderTypeEnum), foodOrderTypeEnum, null)
        };
        return restaurant;
    }
}