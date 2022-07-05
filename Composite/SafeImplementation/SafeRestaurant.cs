namespace Composite.SafeImplementation;

public static class SafeRestaurant
{
    public static void Run()
    {
        Console.WriteLine("====================SafeRestaurant====================");
        var restaurant = new SafeComposite("Restaurant");

        var foods = new SafeComposite ("Foods");
        restaurant.Add (foods);

        var traditional = new SafeComposite ("Traditional");
        var fastFood = new SafeComposite ("Fast Food");
        foods.Add(traditional);
        foods.Add(fastFood);

        fastFood.Add(new SafeLeaf("Pizza",76));
        fastFood.Add(new SafeLeaf("Sandwich",29));

        traditional.Add(new SafeLeaf("Kebab",65));
        traditional.Add(new SafeLeaf("Chicken",55));

        // Recursively display nodes 
        restaurant.GetMenu (1);
        Console.WriteLine("Restaurant Order(s) Count : " + restaurant.GetOrdersCount());
        Console.WriteLine("Traditional foods Order(s) Count : " + traditional.GetOrdersCount());
        Console.WriteLine("Fast foods Order(s) Count : " + fastFood.GetOrdersCount());
    }
}