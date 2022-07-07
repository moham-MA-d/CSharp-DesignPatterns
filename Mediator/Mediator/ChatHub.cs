using Mediator.Colleague;

namespace Mediator.Mediator;

public abstract class ChatHub
{
    public abstract void RegisterColleague(ChatColleague chatColleague);
    public abstract void SendToAll(string from, string message);
    public abstract void SendToTeam<T>(string from, string message) where T : ChatColleague;
}