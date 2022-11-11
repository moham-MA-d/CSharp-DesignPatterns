using Visitor;
using Visitor.Models;
using Visitor.Visitor;

var canvas = new Canvas();

canvas.Add(new Pen());
canvas.Add(new Pencil());

Console.WriteLine("====================Visitor====================");

canvas.Draw(new Circle());
canvas.Draw(new Square());