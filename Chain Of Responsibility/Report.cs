using Chain_Of_Responsibility.Models;

namespace Chain_Of_Responsibility;

public static class Report
{
    public static void Display(string title, Order order)
    {
        Console.WriteLine($"===================={title}====================");
        foreach (var restaurant in order.Restaurants)
        {
            Console.WriteLine($"Restaurant: {restaurant.RestaurantName}");
            foreach (var food in restaurant.AvailableFoods)
            {
                Console.WriteLine($"\t Food: {food.Name}\t Available: {food.AvailableCount}");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine($"Paid Money: {order.Paid}");
        Console.WriteLine($"Shipping Status: {order.DeliveryStatus} \n");
    }
}