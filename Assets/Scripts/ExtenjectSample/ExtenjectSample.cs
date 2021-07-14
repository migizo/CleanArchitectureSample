using UnityEngine;
using Zenject; // 以前はExtenjectではなくZenjectという名称であったためその名残らしい。 

namespace ExtenjectSample
{
  public class ExtenjectSample : MonoBehaviour
  {
    ITestable test; // [Inject]属性を指定することで依存性の注入が可能になる

    [Inject]
    public void Constractor(ITestable test)
    {
      this.test = test;
    }
    void Start()
    {
      Debug.Log(test.GetText());
    }
  }

  public interface ITestable
  {
    string GetText();
  }

  //----------------------------------------------
  public class Hoge : ITestable
  {
    public string GetText()
    {
      return "hoge";
    }
  }

  //----------------------------------------------
  public class Huga : ITestable
  {
    public string GetText()
    {
      return "huga";
    }
  }

}

