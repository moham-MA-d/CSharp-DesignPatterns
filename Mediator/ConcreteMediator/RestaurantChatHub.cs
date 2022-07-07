using Mediator.Colleague;
using Mediator.Mediator;

namespace Mediator.ConcreteMediator;

public class RestaurantChatHub : ChatHub
{
    private readonly List<ChatColleague> _colleagues = new();

    public override void RegisterColleague(ChatColleague chatColleague)
    {
        chatColleague.SetChatroom(this);
        _colleagues.Add(chatColleague);
    }
    public void RegisterColleaguesBatch(params ChatColleague[] chatColleagues)
    {
        foreach (var colleague in chatColleagues)
        {
            RegisterColleague(colleague);
        }
    }

    public override void SendToAll(string from, string message)
    {
        _colleagues.ForEach(colleague => colleague.Receive(from, message));
    }

    public override void SendToTeam<T>(string from, string message)
    {
        _colleagues.OfType<T>().ToList().ForEach(colleague => colleague.Receive(from, message));
    }
    
}
