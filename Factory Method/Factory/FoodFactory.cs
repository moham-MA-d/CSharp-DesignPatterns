using Factory_Method.Enum;
using Factory_Method.Models;
using Factory_Method.Models.Base;

namespace Factory_Method.Factory;

public static class FoodFactory
{
    public static IFood CreateFoodFactory(FoodOrderTypeEnum foodOrderTypeEnum)
    {
        IFood food = foodOrderTypeEnum switch
        {
            FoodOrderTypeEnum.DineIn => new DineInFood(),
            FoodOrderTypeEnum.TakeAway => new TakeAwayFood(),
            _ => throw new ArgumentOutOfRangeException(nameof(foodOrderTypeEnum), foodOrderTypeEnum, null)
        };
        return food;
    }
}