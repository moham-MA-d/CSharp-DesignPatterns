using State.Models;
using State.State;

Console.WriteLine("====================State Pattern====================");

var chef = new Chef();
chef.SetOrder(new Pizza());
chef.PrepareFood();
chef.CookFood();
