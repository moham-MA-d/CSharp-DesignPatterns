using Visitor.Models;
namespace Visitor.Visitor;

public class Circle : IShape {
  public void Apply(Pen pen) {
    Console.WriteLine("drawing circle by pen");
  }
  public void Apply(Pencil pencil) {
    Console.WriteLine("drawing circle by pencil");
  }
}