using Strategy.Models;

namespace Strategy.Strategy;

public interface ICookStrategy
{
    string Cook();
    int Price(int price);
}
