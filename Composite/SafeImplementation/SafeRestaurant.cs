namespace Composite.SafeImplementation;

public static class SafeRestaurant
{
    public static void Run()
    {
        Console.WriteLine("====================SafeRestaurant====================");
        var restaurant = new SafeComposite("Restaurant");
        restaurant.Add (new SafeLeaf("Name: Star Restaurant"));

        var foods = new SafeComposite ("Foods");
        restaurant.Add (foods);

        var traditional = new SafeComposite ("Traditional");
        var fastFood = new SafeComposite ("Fast Food");
        foods.Add(traditional);
        foods.Add(fastFood);

        fastFood.Add(new SafeLeaf("Pizza"));
        fastFood.Add(new SafeLeaf("Sandwich"));

        traditional.Add(new SafeLeaf("Kebab"));
        traditional.Add(new SafeLeaf("Chicken"));

        var employee = new SafeLeaf ("Employee");
        restaurant.Add (employee);
        restaurant.Remove (employee);

        // Recursively display nodes 
        restaurant.Display (1);
    }
}