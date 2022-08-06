namespace State.Models;

public class Chicken: IFood {
    public void Prepare() {
        Console.WriteLine("Chicken is preparing");
    }

    public void Cook() {
        Console.WriteLine("Chicken is cooking");
    }
}
