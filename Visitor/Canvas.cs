using Visitor.Models;
using Visitor.Visitor;
namespace Visitor;

public class Canvas {
  
  private readonly List<IDrawTool> _tools = new ();
  public void Add(IDrawTool tool) {
    _tools.Add(tool);
  }
  public void Draw(IShape shape) {
    foreach (var tool in _tools)
      tool.Draw(shape);
  }
}