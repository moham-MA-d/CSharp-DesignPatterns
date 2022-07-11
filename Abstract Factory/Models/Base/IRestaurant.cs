namespace Abstract_Factory.Models.Base;

public interface IRestaurant
{
    IFastFood GetFastFood();
    ITraditionalFood GetTraditionalFood();
}