using Visitor.Visitor;
namespace Visitor.Models;

public class Pencil : IDrawTool
{
    public void Draw(IShape shape)
    {
        shape.Apply(this);
    }
}