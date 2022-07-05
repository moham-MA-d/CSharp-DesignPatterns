using Composite.SafeImplementation;
using Composite.UniformImplementation;
using Composite.WithBuilderPattern.SafeImplementation;
using Composite.WithBuilderPattern.UniformImplementation;

/* Choose which implementation you are going to Run */

SafeRestaurant.Run();

UniformRestaurant.Run();

SafeRestaurantWb.Run();

UniformRestaurantWb.Run();


// Wait for user
Console.ReadKey ();