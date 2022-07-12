using Prototype.Models;
using Prototype.Prototype;

Console.WriteLine("====================Prototype Default====================");
var johnOrder = new FoodOrder("John", new Food("Chicken", 2));
johnOrder.Display();

Console.WriteLine("====================Prototype Cloned====================");
var johnOrderCloned = (FoodOrder) johnOrder.DeepCopy();
johnOrderCloned.Display();

Console.WriteLine("====================Prototype Has Changed====================");
johnOrder.CustomerName = "Jane";
johnOrder.Food.Name = "Sandwich";
johnOrder.Display();
johnOrderCloned.Display();



Console.WriteLine("====================Prototype Using Manager====================");
var manager = new PrototypeManager
{
    [1] = new FoodOrder("Mohammad", new Food("Kebab", 1)),
    [2] = new FoodOrder("Sarah", new Food("Pizza", 2))
};
manager[1].Display();
manager[2].Display();

Console.WriteLine("====================Prototype Using Manager Has Changed====================");
var sarahOrder = (FoodOrder)manager[2].ShallowCopy();
sarahOrder.Food.Count = 1;
manager[2].Display();


