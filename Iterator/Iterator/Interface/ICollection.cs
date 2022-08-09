namespace Iterator.Iterator;

public interface ICollection<out T>
{
    T CreateIterator();
}