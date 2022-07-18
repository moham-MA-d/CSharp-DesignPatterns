using Decorator.Decorator;
using Decorator.Service;
using Microsoft.Extensions.Caching.Memory;

IMemoryCache cache = new MemoryCache(new MemoryCacheOptions());
IFoodService foodService = new FoodService();
IFoodService cachedFoodService = new CachedFoodService(cache, foodService);

Console.WriteLine("====================Foods From Server====================");
var foods = cachedFoodService.GetFoods();
foreach (var food in foods)
{
    Console.WriteLine($"Food name: {food.Name} Price: {food.Price} ");
}

Console.WriteLine("====================Foods From Cache by Decorator====================");
var foods1 = cachedFoodService.GetFoods();
foreach (var food in foods1)
{
    Console.WriteLine($"Food name: {food.Name} Price: {food.Price} ");
}