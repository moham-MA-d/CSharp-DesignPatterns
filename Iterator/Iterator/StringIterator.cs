using Iterator.Iterator.Interface;

namespace Iterator.Iterator;

public class StringIterator : IIterator<string>
{
    private int _step = 1;
    private int _current = 0;
    private readonly StringCollection _foodCollection;

    public StringIterator(StringCollection foodCollection)
    {
        _foodCollection = foodCollection;
    }

    public string First()
    {
        _current = 0;
        return _foodCollection[_current];
    }

    public string Next()
    {
        _current += _step;
        if (!IsDone)
            return _foodCollection[_current];
        else
            return null;
    }

    public string Current => _foodCollection[_current];

    public bool IsDone => _current >= _foodCollection.Count;


    public int Step
    {
        get => _step;
        set => _step = value;
    }
    
}