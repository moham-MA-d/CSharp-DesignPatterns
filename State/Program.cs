using State.Models;
using State.State;

Console.WriteLine("====================State====================");

var chef = new Chef();
chef.SetOrder(new Pizza());
chef.PrepareFood();
chef.CookFood();
