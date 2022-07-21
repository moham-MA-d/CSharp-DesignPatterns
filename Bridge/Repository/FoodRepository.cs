using Bridge.Models;

namespace Bridge.Repository;

public class FoodRepository
{
    private List<Food> Foods { get; set; } = new();

    private int Add(Food food)
    {
        var highestId = Foods.Any() ? Foods.Max(x => x.Id) :0;
        food.Id = highestId + 1;
        Foods.Add(food);

        return food.Id;
    }

    public void Display()
    {
        Console.WriteLine("Food name \t Status");
        foreach (var food in Foods)
        {
            Console.WriteLine($"{food.Name} \t\t {food.IsPayed}");
        }
    }
    
    public void Cook(int foodId, int paidPrice)
    {
        var food = Foods.FirstOrDefault(x => x.Id == foodId);
        if (food == null) return;
        
        var price = GetPrice(food.Name);
        if (price == paidPrice)
        {
            food.IsPayed = true;
        }
    }


    private int GetPrice(Food.FoodEnum name)
    {
        return name switch
        {
            Food.FoodEnum.Pizza => 20,
            Food.FoodEnum.Sandwich => 12,
            Food.FoodEnum.Kebab => 25,
            Food.FoodEnum.Chicken => 15,
            _ => throw new ArgumentOutOfRangeException(nameof(name), name, null)
        };
    }
    
    public int Order(Food.FoodEnum foodName, Food.OrderTypeEnum orderType)
    {
        return foodName switch
        {
            Food.FoodEnum.Pizza => Add(new Food(foodName, orderType)),
            Food.FoodEnum.Sandwich => Add(new Food(foodName, orderType)),
            Food.FoodEnum.Kebab => Add(new Food(foodName, orderType)),
            Food.FoodEnum.Chicken => Add(new Food(foodName, orderType)),
            _ => 0
        };
    }

}