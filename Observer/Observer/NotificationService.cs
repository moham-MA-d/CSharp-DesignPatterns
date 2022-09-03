
using Observer.Subject;

namespace Observer.Observer;

public class NotificationService : IObserver
{
    
    private readonly List<IFood> _foods = new();

    public void AddFood(IFood food) {
        _foods.Add(food);
        food.AddObserver(this);
    }

    private void Display() {
        Console.WriteLine("\n Notification Service: ");
        foreach (var food in _foods)
            Console.WriteLine(food);
    }

    public void Update()
    {
        Display();
    }
}