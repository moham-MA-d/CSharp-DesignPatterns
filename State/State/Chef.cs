using State.Models;

namespace State.State;

public class Chef {
  private IFood CurrentFood;
  public void SetOrder(IFood currentFood) {
    CurrentFood = currentFood;
  }
  
  
  public void PrepareFood() {
    CurrentFood.Prepare();
  }

  public void CookFood() {
    CurrentFood.Cook();
  }
  
}