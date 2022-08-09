using Iterator.Iterator;

Console.WriteLine("====================Iterator implementation with a class====================");
var foodsClass = new FoodCollection
{
    [0] = new ("Pizza"),
    [1] = new ("Kebab"),
    [2] = new ("Sandwich"),
    [3] = new ("Chicken"),
};

var iteratorClass = foodsClass.CreateIterator();
iteratorClass.Step = 2;

for (var food = iteratorClass.First();
     !iteratorClass.IsDone; food = iteratorClass.Next())
{
    Console.WriteLine(food.Name);
}



Console.WriteLine("====================Iterator implementation with string====================");
var foodsStringArray = new StringArrayCollection()
{
    [0] = "Pizza",
    [1] = "Kebab",
    [2] = "Sandwich",
    [3] = "Chicken",
};
var iteratorStringArray = foodsStringArray.CreateIterator();
iteratorStringArray.Step = 2;

for (var food = iteratorStringArray.First();
     !iteratorStringArray.IsDone; food = iteratorStringArray.Next())
{
    Console.WriteLine(food);
}

Console.ReadKey();