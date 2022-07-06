namespace Builder.Models;
public class Food
{
    public readonly string _name;
    public readonly int _price;
    public readonly Size _size;

    public Food(string productName, int price, Size size)
    {
        _name = productName;
        _price = price;
        _size = size;
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }
}