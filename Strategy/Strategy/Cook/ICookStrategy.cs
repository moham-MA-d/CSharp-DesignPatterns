namespace Strategy.Strategy.Cook;

public interface ICookStrategy
{
    string Cook();
    int Price(int price);
}
