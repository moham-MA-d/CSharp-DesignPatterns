namespace Iterator.Iterator;

public class Collection : ICollection
{
    private readonly List<Food> _foods = new ();

    public Iterator CreateIterator()
    {
        return new Iterator(this);
    }

    public int Count => _foods.Count;

    public Food this[int index]
    {
        get => _foods[index];
        set => _foods.Add(value);
    }
}