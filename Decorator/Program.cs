using Decorator.Decorator;
using Decorator.Service;
using Microsoft.Extensions.Caching.Memory;

IMemoryCache cache = new MemoryCache(new MemoryCacheOptions());
IFoodService foodService = new FoodService();
IFoodService cachedFoodService = new CachedFoodService(cache, foodService);

Console.WriteLine("====================Foods From Server====================");
var firstCallForFoods = cachedFoodService.GetFoods();
foreach (var food in firstCallForFoods)
{
    Console.WriteLine($"Food name: {food.Name} Price: {food.Price} ");
}

Console.WriteLine("\n ====================Foods From Cache by Decorator====================");
var secondCallForFoods = cachedFoodService.GetFoods();
foreach (var food in secondCallForFoods)
{
    Console.WriteLine($"Food name: {food.Name} Price: {food.Price} ");
}