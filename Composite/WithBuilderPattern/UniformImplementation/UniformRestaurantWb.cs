using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace Composite.WithBuilderPattern.UniformImplementation;

public static class UniformRestaurantWb
{
    public static void Run()
    {
        Console.WriteLine("====================UniformRestaurantWb====================");
        var builder = new UniformBuilder("Builder Restaurant");
        builder.AddFoodType("Foods");
        builder.AddFoodType("Fast Food");
        builder.AddFood("Pizza", 76);
        builder.AddFood("Sandwich", 29);
        builder.SelectFoodType("Foods");
        builder.AddFoodType("Traditional");
        builder.AddFood("Kebab", 65);
        builder.AddFood("Chicken", 55);

        Console.WriteLine($"Total Orders : {builder.BusinessType.GetOrdersCount()}");
        Console.WriteLine(JsonConvert.SerializeObject(builder.BusinessType, (Newtonsoft.Json.Formatting) Formatting.Indented));
        
    }
}