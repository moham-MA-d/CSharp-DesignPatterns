namespace Chain_Of_Responsibility.Models;

public class Restaurant
{
    public RestaurantName RestaurantName { get; set; }
    public Restaurant(RestaurantName name)
    {
        RestaurantName = name;
    }
    public List<Food> AvailableFoods { get; set; } = new ();
}

public enum RestaurantName
{
    Star,
    DarkBlue,
    Sun
}

public enum DeliveryStatus 
{ 
    WaitingForPayment,
    ReadyToDeliver,
}