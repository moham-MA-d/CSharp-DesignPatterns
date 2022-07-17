using Facade.Models;

namespace Facade
{
    public interface IFoodFacade
    {
        FoodOrderResult GetFood(string foodName, string drinkName);
    }
}