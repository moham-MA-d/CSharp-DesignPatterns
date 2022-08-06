
namespace State.Models;

public class Kebab : IFood {
  public void Prepare() {
    Console.WriteLine("Kebab is preparing");
  }

  public void Cook() {
    Console.WriteLine("Kebab is cooking");
  }
}