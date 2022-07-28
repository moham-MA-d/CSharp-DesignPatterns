using Strategy.Models;
using Strategy.Strategy;

Console.WriteLine("====================Strategy====================");

var pizzaInSlowMode = new Pizza()
{
    Price = 10,
    CookStrategy = new SlowCookStrategy()
};
pizzaInSlowMode.Cook();

var pizzaInFastMode = new Pizza()
{
    Price = 10,
    CookStrategy = new FastCookStrategy()
};
pizzaInFastMode.Cook();



Console.ReadKey();