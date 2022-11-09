using Mediator.Mediator;

namespace Mediator.Colleague;

public abstract class ChatColleague
{
    private ChatHub _chatHub;
    protected string Name { get; }

    protected ChatColleague(string name)
    {
        Name = name;
    }

    internal void SetChatroom(ChatHub chatHub)
    {
        _chatHub = chatHub;
    }

    public void SendToAll(string message)
    {
        _chatHub.SendToAll(this.Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"from {from}: '{message}'");
    }

    public void SendToTeam<T>(string message) where T : ChatColleague
    {
        _chatHub.SendToTeam<T>(this.Name, message);
    }
}
