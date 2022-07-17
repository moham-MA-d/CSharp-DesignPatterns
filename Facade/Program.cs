using System;
using Facade.Models;
using Facade.Services;

namespace Facade
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================Facade====================");
            
            const string foodName = "Pizza";
            const string drinkName = "Soda";
            
            var foodFacade = new FoodFacade();
            var results = foodFacade.GetFood(foodName, drinkName);
            
            Console.WriteLine($"The {results.Name} is ordered Successfully, Price: {results.Price}, Drink:{results.Drink}");
        }
    }
}