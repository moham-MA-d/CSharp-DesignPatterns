namespace Iterator.Iterator.Interface;

public interface IIterator<out T>
{
    T First();
    T Next();
    bool IsDone { get; }
    T Current { get; }
}