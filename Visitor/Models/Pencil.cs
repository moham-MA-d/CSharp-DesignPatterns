using Visitor.Visitor;
namespace Visitor.Models;

public class Pencil : IDrawTool
{
    public void Draw(IOperation operation)
    {
        operation.Apply(this);
    }
}