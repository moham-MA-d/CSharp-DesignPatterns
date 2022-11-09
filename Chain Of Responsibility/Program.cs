using Chain_Of_Responsibility;
using Chain_Of_Responsibility.Handlers;
using Chain_Of_Responsibility.Handlers.RestaurantHandlers;
using Chain_Of_Responsibility.Models;

var order = new Order();
order.OrderedFoods.Add(new Food(FoodsName.Sandwich,  12));
order.OrderedFoods.Add(new Food(FoodsName.Kebab,  24));
order.OrderedFoods.Add(new Food(FoodsName.Chicken,  15));


var handler = new RestaurantHandler(
    new StarHandler(),
    new SunHandler(),
    new DarkBlueHandler()
);


handler.RestaurantHandle(order);
Report.Display("Before Chain Of Responsibility", order);


handler.Handle(order);
Report.Display("After Chain Of Responsibility", order);



Console.ReadKey();

