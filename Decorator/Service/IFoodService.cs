using Decorator.Models;

namespace Decorator.Service;

public interface IFoodService
{
    IEnumerable<Food> GetFoods();
}