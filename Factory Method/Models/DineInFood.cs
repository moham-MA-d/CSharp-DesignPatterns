using Factory_Method.Enum;
using Factory_Method.Models.Base;

namespace Factory_Method.Models;

public class DineInFood : IFood
{
    public void Cook()
    {
        Console.WriteLine($"{nameof(DineInFood)} is Cooked...");
    }

    public void Order()
    {
        Console.WriteLine($"{nameof(DineInFood)} is Ordered...");
    }

}