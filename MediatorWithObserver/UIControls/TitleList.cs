
namespace MediatorWithObserver.UIControls;

public class TitleList : UIControl {
  
  private string _selection;
  public string GetSelection() {
    return _selection;
  }

  public void SetSelection(string selection) {
    _selection = selection;
    NotifyEventHandlers();
  }
}