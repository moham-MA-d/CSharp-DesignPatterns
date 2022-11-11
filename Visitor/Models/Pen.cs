using Visitor.Visitor;

namespace Visitor.Models;

public class Pen : IDrawTool {
  public void Draw(IOperation operation) {
    operation.Apply(this);
  }
}