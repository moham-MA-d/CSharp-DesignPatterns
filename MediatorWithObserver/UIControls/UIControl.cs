using MediatorWithObserver.Observer;

namespace MediatorWithObserver.UIControls;

public abstract class UIControl {
  
  private readonly List<IEventHandler> _eventHandlers = new();

  public void AddEventHandler(IEventHandler eventHandler) {
    _eventHandlers.Add(eventHandler);
  }

  protected void NotifyEventHandlers() {
    foreach (var eventHandler in _eventHandlers)
      eventHandler.Handle();
  }
}