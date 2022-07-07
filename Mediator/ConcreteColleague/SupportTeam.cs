using Mediator.Colleague;

namespace Mediator.ConcreteColleague;

public class SupportTeam : ChatColleague
{
    public SupportTeam(string name) : base(name) { }

    public override void Receive(string from, string message)
    {
        Console.Write($"{Name} ({nameof(SupportTeam)}) has received: ");
        base.Receive(from, message);
    }
}