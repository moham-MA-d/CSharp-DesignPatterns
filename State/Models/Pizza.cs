
namespace State.Models;

public class Pizza : IFood {
  public void Prepare() {
    Console.WriteLine("Pizza is preparing");
  }

  public void Cook() {
    Console.WriteLine("Pizza is cooking");
  }
}