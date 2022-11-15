namespace MediatorWithObserver.UIControls;
public class Button : UIControl {
  
  private bool _isEnabled;

  public bool IsEnabled() {
    return _isEnabled;
  }

  public void SetEnabled(bool enabled) {
    _isEnabled = enabled;
    NotifyEventHandlers();
  }
}