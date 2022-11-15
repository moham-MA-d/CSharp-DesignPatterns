using MediatorWithObserver.Mediator;

namespace MediatorWithObserver.Observer;

public class TitleHandler : IEventHandler
{
    private readonly Modal _modal;

    public TitleHandler(Modal modal)
    {
        _modal = modal;
    }
    public void Handle()
    {
        _modal.ArticleSelected();
    }
}