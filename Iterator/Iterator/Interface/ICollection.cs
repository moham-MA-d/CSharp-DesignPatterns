namespace Iterator.Iterator.Interface;

public interface ICollection<out T>
{
    T CreateIterator();
}