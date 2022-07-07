using Mediator.Colleague;

namespace Mediator.ConcreteColleague;

public class ClientTeam : ChatColleague
{
    public ClientTeam(string name) : base(name) { }

    public override void Receive(string from, string message)
    {
        Console.Write($"{Name} ({nameof(ClientTeam)}) has received: ");
        base.Receive(from, message);
    }
}