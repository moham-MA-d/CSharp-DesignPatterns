
using Visitor.Models;

namespace Visitor.Visitor;

public interface IOperation {
  void Apply(Pen pen);
  void Apply(Pencil pencil);
}