using TemplateMethod.Models;

var pizza = new Pizza();
var kebab = new Kebab();

Console.WriteLine("====================TemplateMethod Pattern====================");
pizza.Order();

kebab.Order();

