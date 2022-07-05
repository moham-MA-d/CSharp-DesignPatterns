namespace Composite.UniformImplementation;
public static class UniformRestaurant
{
    public static void Run()
    {
        Console.WriteLine("====================UniformRestaurant====================");
        var restaurant = new UniformComposite("Restaurant");
        restaurant.Add (new UniformLeaf("Name: Star Restaurant"));

        var foods = new UniformComposite ("Foods");
        restaurant.Add (foods);

        var traditional = new UniformComposite ("Traditional");
        var fastFood = new UniformComposite ("Fast Food");
        foods.Add(traditional);
        foods.Add(fastFood);

        fastFood.Add(new UniformLeaf("Pizza"));
        fastFood.Add(new UniformLeaf("Sandwich"));

        traditional.Add(new UniformLeaf("Kebab"));
        traditional.Add(new UniformLeaf("Chicken"));

        var employee = new UniformLeaf ("Employee");
        employee.Add(new UniformLeaf("Waiter")); // A Uniform Leaf Cannot Implement Add Method
        restaurant.Add (employee);
        restaurant.Remove (employee);

        // Recursively display nodes 
        restaurant.Display (1);
    }
}