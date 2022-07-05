namespace Composite.UniformImplementation;
public static class UniformRestaurant
{
    public static void Run()
    {
        Console.WriteLine("====================UniformRestaurant====================");
        var restaurant = new UniformComposite("Restaurant");

        var foods = new UniformComposite ("Foods");
        restaurant.Add (foods);

        var traditional = new UniformComposite ("Traditional");
        var fastFood = new UniformComposite ("Fast Food");
        foods.Add(traditional);
        foods.Add(fastFood);

        fastFood.Add(new UniformLeaf("Pizza",76));
        fastFood.Add(new UniformLeaf("Sandwich",29));

        traditional.Add(new UniformLeaf("Kebab",65));
        traditional.Add(new UniformLeaf("Chicken",55));

        var drinks = new UniformLeaf ("Drinks",0);
        drinks.Add(new UniformLeaf("Water",10)); // A Uniform Leaf Cannot Implement Add Method
        restaurant.Add (drinks);
        restaurant.Remove (drinks);

        // Recursively display nodes 
        restaurant.GetMenu (1);
        Console.WriteLine("Restaurant Order(s) Count : " + restaurant.GetOrdersCount());
        Console.WriteLine("Traditional foods Order(s) Count : " + traditional.GetOrdersCount());
        Console.WriteLine("Fast foods Order(s) Count : " + fastFood.GetOrdersCount());
    }
}