
using Visitor.Visitor;

namespace Visitor.Models;

public interface IDrawTool {
  void Draw(IOperation operation);
}