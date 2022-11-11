
using Visitor.Models;

namespace Visitor.Visitor;

public interface IShape {
  void Apply(Pen pen);
  void Apply(Pencil pencil);
}