
namespace State.Models;

public class Sandwich : IFood {
  public void Prepare() {
      Console.WriteLine("Sandwich is preparing");
    }
  
    public void Cook() {
      Console.WriteLine("Sandwich is cooking");
    }
}