using Memento;
using Memento.Models;

var pizza = new Food
{
    Name = "Pizza"
};
var kebab = new Food
{
    Name = "Kebab"
};

var shoppingCart = new ShoppingCart();
var history = new ShoppingCartStateHistory();

shoppingCart.AddFood(pizza);
history.Push(shoppingCart.CreateState());

shoppingCart.AddFood(kebab);
history.Push(shoppingCart.CreateState());

shoppingCart.Restore(history.Pop());

var foods = shoppingCart.GetFoods();
foreach (var food in foods)
{
    Console.WriteLine(food.Name);
}

Console.ReadKey();


