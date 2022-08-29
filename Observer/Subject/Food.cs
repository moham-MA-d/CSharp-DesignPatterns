using Observer.Observer;
namespace Observer.Subject;

public class Food
{
    
    private float _price;
    private readonly string _name;
    private readonly List<IObserver> _observers = new(); 

    public Food(string name, float price) {
        _name = name;
        _price = price;
    }

    public float GetPrice() {
        return _price;
    }

    public void SetPrice(float price) {
        _price = price;
        NotifyObservers();
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
    
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers() {
        foreach (var observer in _observers)
            observer.Update();
    }
    
    public override string ToString() {
        return "Food {" +
               "Name= '" + _name + '\'' +
               ", Price=" + _price +
               '}';
    }
}