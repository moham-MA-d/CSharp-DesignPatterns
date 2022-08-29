using Observer.Subject;
namespace Observer.Observer;

public class Menu : IObserver
{
    private readonly List<Food> _foods = new();

    public void AddFood(Food food) {
        _foods.Add(food);
        food.AddObserver(this);
    }

    private void Display() {
        Console.WriteLine("Menu: ");
        foreach (var food in _foods)
            Console.WriteLine(food);
    }

    public void Update()
    {
        Console.WriteLine("Update: ");
        Display();
    }
}