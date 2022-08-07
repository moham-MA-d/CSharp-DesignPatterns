// Build a collection

using Iterator.Iterator;

var collection = new Collection
{
    [0] = new ("Pizza"),
    [1] = new ("Kebab"),
    [2] = new ("Sandwich"),
    [3] = new ("Chicken"),
};


var iterator = collection.CreateIterator();

iterator.Step = 2;

Console.WriteLine("Iterating over collection:");

for (var food = iterator.First();
     !iterator.IsDone; food = iterator.Next())
{
    Console.WriteLine(food.Name);
}

Console.ReadKey();