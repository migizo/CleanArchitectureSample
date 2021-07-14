public class Counter
{
  public int value { get; private set; }
  public Counter()
  {
    value = 0;
  }
  public void Increment()
  {
    value++;
  }
}
