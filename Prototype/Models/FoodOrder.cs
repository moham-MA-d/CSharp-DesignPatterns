using Prototype.Prototype;

namespace Prototype.Models;

public class FoodOrder: IPrototype
{
    public string CustomerName;
    public Food Food;

    public FoodOrder(string name,  Food food)
    {
        CustomerName = name;
        Food = food;
    }

    public IPrototype ShallowCopy()
    {
        return (IPrototype)MemberwiseClone();
    }

    public IPrototype DeepCopy()
    {
        var clonedOrder = (FoodOrder)MemberwiseClone();
        clonedOrder.Food = new Food(Food.Name, Food.Count);

        return clonedOrder;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {CustomerName}");
        Console.WriteLine($"Details: {Food.Name} {Food.Count} \n");
    }
}