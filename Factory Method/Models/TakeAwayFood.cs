using Factory_Method.Enum;
using Factory_Method.Models.Base;

namespace Factory_Method.Models;

public class TakeAwayFood : IFood
{
    public  void Cook()
    {
        Console.WriteLine($"{nameof(TakeAwayFood)} is Cooked...");
    }

    public  void Order()
    {
        Console.WriteLine($"{nameof(TakeAwayFood)} is Ordered...");
    }

}