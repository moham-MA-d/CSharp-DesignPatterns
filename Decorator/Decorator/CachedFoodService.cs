using Decorator.Models;
using Decorator.Service;
using Microsoft.Extensions.Caching.Memory;

namespace Decorator.Decorator;

public class CachedFoodService : IFoodService
{
    private readonly IMemoryCache _cache;
    private readonly IFoodService _foodService;

    public CachedFoodService(IMemoryCache cache, IFoodService foodService)
    {
        _cache = cache;
        _foodService = foodService;
    }

    public List<Food> GetFoods()
    {
        const string cacheKey = "FoodMenu";
        if (_cache.TryGetValue<List<Food>>(cacheKey, out var foods))
        {
            Console.WriteLine("Cached Result");
            return foods;
        }

        var foodsMenu = _foodService.GetFoods();
        _cache.Set(cacheKey, foodsMenu, TimeSpan.FromMinutes(19));
        return foodsMenu;
    }
}