using Observer.Observer;
using Observer.Subject;

var kebab = new Food("Kebab", 24);

var menu = new Menu();
var notService = new NotificationService();

menu.AddFood(kebab);
notService.AddFood(kebab);

Console.WriteLine("====================Observer Pattern====================");

kebab.SetPrice(25);

Console.ReadKey();