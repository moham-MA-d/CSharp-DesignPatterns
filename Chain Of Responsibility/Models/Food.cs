namespace Chain_Of_Responsibility.Models;

public class Food
{
    public FoodsName Name { get; }
    public int Price { get; }
    public bool IsPaid { get; set; }
    public int AvailableCount { get; set; }
    public Food(FoodsName name, int price)
    {
        Name = name;
        Price = price;
    }
    public Food(FoodsName name, int price, int availableCount)
    {
        Name = name;
        Price = price;
        AvailableCount = availableCount;
    }
}

public enum FoodsName
{
    Pizza,
    Sandwich,
    Kebab,
    Chicken
}