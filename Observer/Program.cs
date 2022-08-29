using Observer.Observer;
using Observer.Subject;

Console.WriteLine("====================Observer Pattern====================");


var pizza = new Food("Pizza", 19);
var kebab = new Food("Kebab", 24);

var menu = new Menu();
var notService = new NotificationService();

menu.AddFood(pizza);
menu.AddFood(kebab);

notService.AddFood(pizza);
notService.AddFood(kebab);

pizza.SetPrice(20);
kebab.SetPrice(25);

Console.ReadKey();