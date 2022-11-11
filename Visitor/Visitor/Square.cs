
using Visitor.Models;

namespace Visitor.Visitor;

public class Square : IShape {
  public void Apply(Pen pen) {
    Console.WriteLine("drawing square by pen");
  }

  public void Apply(Pencil pencil) {
    Console.WriteLine("drawing square by pencil");
  }
}