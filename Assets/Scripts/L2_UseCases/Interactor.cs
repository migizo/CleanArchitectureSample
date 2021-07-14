public class Interactor : IInteractor
{
  Counter counter;
  IPresenter presenter;

  public Interactor(IPresenter presenter)
  {
    counter = new Counter();
    this.presenter = presenter;
  }
  public void CountUp()
  {
    if (counter != null)
    {
      counter.Increment();

      if (presenter != null) presenter.ShowCount(counter.value);
    }
  }

  public int GetValue()
  {
    if (counter != null) return counter.value;
    return -1;
  }
}
