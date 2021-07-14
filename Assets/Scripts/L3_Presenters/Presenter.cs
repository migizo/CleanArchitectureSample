public class Presenter : IPresenter
{
  IView view;
  public Presenter(IView view)
  {
    this.view = view;
  }
  public void ShowCount(int count)
  {
    var countText = count.ToString();
    if (view != null) view.UpdateText(countText);
  }
}
