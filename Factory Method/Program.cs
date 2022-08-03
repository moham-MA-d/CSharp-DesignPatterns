using Factory_Method.Enum;
using Factory_Method.Factory;

Console.WriteLine("====================Factory Method====================");

Console.WriteLine("Please enter the order type: \n\n Dine in: 1 \n Takeaway: 2");

var foodOrderTypeEnum = (FoodOrderTypeEnum)Convert.ToInt16(Console.ReadLine());

var food = FoodFactory.CreateFoodFactory(foodOrderTypeEnum);
food.Cook();
food.Order();

Console.ReadKey();


