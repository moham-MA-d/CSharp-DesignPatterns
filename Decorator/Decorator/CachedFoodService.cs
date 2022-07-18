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
    public IEnumerable<Food> GetFoods()
    {
        
        var cacheKey = "FoodMenu";
        if (_cache.TryGetValue<IEnumerable<Food>>(cacheKey, out var foods))
        {
            Console.WriteLine("Cached Result");
            return foods;
        }
        else
        {
            var currentConditions = _foodService.GetFoods();
            _cache.Set<IEnumerable<Food>>(cacheKey, currentConditions, TimeSpan.FromMinutes(19));
            return currentConditions;
        }
    }
}