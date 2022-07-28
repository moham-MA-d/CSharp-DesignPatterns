using Strategy.Strategy;

namespace Strategy.Models;

public abstract class Food
{
    public int Price { get; set; }
    public abstract void Cook();
    public ICookStrategy CookStrategy { get; set; }
}
