using Iterator.Models;

namespace Iterator.Iterator;

public class FoodCollection : ICollection<FoodIterator>
{
    private readonly List<Food> _foods = new ();

    public FoodIterator CreateIterator()
    {
        return new FoodIterator(this);
    }

    public int Count => _foods.Count;

    public Food this[int index]
    {
        get => _foods[index];
        init => _foods.Add(value);
    }
}