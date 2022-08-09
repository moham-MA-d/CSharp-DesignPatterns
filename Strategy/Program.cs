using Strategy.Models;
using Strategy.Strategy.Cook;
using Strategy.Strategy.Payment;

Console.WriteLine("====================Strategy====================");
var pizza = new Pizza()
{
    Price = 10
};
pizza.Cook(new SlowCookStrategy(), new MasterCardStrategy());



Console.ReadKey();