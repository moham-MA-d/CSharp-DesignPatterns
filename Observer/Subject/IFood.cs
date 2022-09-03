using Observer.Observer;

namespace Observer.Subject;

public interface IFood
{
    int GetPrice();
    void SetPrice(int price);
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
}