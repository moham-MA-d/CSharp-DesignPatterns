namespace Iterator.Iterator;

public interface IIterator<T>
{
    T First();
    T Next();
    bool IsDone { get; }
    T Current { get; }
}