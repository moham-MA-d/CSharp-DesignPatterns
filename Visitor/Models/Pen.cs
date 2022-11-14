using Visitor.Visitor;
namespace Visitor.Models;

public class Pen : IDrawTool {
  public void Draw(IShape shape) {
    shape.Apply(this);
  }
}