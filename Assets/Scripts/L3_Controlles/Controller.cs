public class Controller
{
  IInteractor interactor;
  public Controller(IInteractor interactor)
  {
    this.interactor = interactor;
  }
  public void CountUp()
  {
    if (interactor != null) interactor.CountUp();
  }
  public int GetValue()
  {
    if (interactor != null) return interactor.GetValue();
    return -1;
  }
}
