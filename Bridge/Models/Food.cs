namespace Bridge.Models;

public class Food
{
    public int Id { get; set; }
    public FoodEnum Name { get; set; }
    private OrderTypeEnum OrderType { get; set; }
    public bool IsPayed { get; set; } 

    
    public Food(FoodEnum name, OrderTypeEnum orderType)
    {
        Name = name;
        OrderType = orderType;
    }
    
  
    public enum OrderTypeEnum
    {
        TakeAway = 1,
        DineIn
    }
    
    // Instead of making a derived class from `Food` we simply created `FoodEnum`
    public enum FoodEnum
    {
        Pizza = 1,
        Sandwich,
        Kebab,
        Chicken
    }
}