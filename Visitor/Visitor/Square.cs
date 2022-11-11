
using Visitor.Models;

namespace Visitor.Visitor;

public class Square : IOperation {
  public void Apply(Pen pen) {
    Console.WriteLine("drawing square by pen");
  }

  public void Apply(Pencil pencil) {
    Console.WriteLine("drawing square by pencil");
  }
}