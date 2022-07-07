using Mediator.Colleague;

namespace Mediator.ConcreteColleague;

public class SellTeam : ChatColleague
{
    public SellTeam(string name) : base(name) { }

    public override void Receive(string from, string message)
    {
        Console.Write($"{Name} ({nameof(SellTeam)}) has received: ");
        base.Receive(from, message);
    }
}