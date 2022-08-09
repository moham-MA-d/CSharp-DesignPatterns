namespace Iterator.Iterator;

public class StringArrayCollection : ICollection<StringArrayIterator>
{
    private readonly List<string> _foods = new();

    public StringArrayIterator CreateIterator()
    {
        return new StringArrayIterator(this);
    }

    public int Count => _foods.Count;

    public string this[int index]
    {
        get => _foods[index];
        init => _foods.Add(value);
    }
    
}