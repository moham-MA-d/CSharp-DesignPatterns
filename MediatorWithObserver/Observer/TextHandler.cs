using MediatorWithObserver.Mediator;

namespace MediatorWithObserver.Observer;

public class TextHandler: IEventHandler
{
    private readonly Modal _modal;

    public TextHandler(Modal modal)
    {
        _modal = modal;
    }
    public void Handle()
    {
        _modal.TitleChanged();
    }
}