using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Tests
{
  public class CounterTest
  {
    GameObject buttonObj;
    GameObject textObj;

    class TestPresenter : IPresenter
    {
      public void ShowCount(int count) { }
    }

    [SetUp]
    public void Init()
    {
      SceneManager.LoadScene("CounterScene");
    }

    [Test]
    public void CounterTest_L1_Entities()
    {
      // arrange: 事前準備
      var counter = new Counter();

      // act: アクション実行
      counter.Increment();

      // assert: 検証
      Assert.That(counter.value == 1);
    }


    [Test]
    public void CounterTest_L2_UseCases()
    {

      // arrange: 事前準備
      var interactor = new Interactor(new TestPresenter());

      // act: アクション実行
      interactor.CountUp();

      // assert: 検証
      Assert.That(interactor.GetValue() == 1);
    }

    [Test]
    public void CounterTest_L3_Controller()
    {
      // arrange: 事前準備
      var interactor = new Interactor(new TestPresenter());
      var controller = new Controller(interactor);

      // act: アクション実行
      controller.CountUp();

      // assert: 検証
      Assert.That(controller.GetValue() == 1);
    }


    [UnityTest]
    public IEnumerator CounterTest_L4_UI()
    {
      // arrange: 事前準備
      if (buttonObj == null) buttonObj = GameObject.Find("CountButton");
      yield return new WaitForSeconds(2f);

      var countButton = buttonObj.GetComponent<CountButton>();
      var button = countButton.GetComponent<Button>();

      var interactor = new Interactor(new TestPresenter());
      var controller = new Controller(interactor);
      countButton.Constructor(controller);

      // act: アクション実行
      button.onClick.Invoke();

      // assert: 検証
      Assert.That(countButton.testCount == 1);
    }

    [UnityTest]
    public IEnumerator CounterTest_L4L5_PresenterView()
    {
      // arrange: 事前準備
      if (textObj == null) textObj = GameObject.Find("CountText");
      yield return new WaitForSeconds(2f);

      var countTextView = textObj.GetComponent<CountTextView>();
      var text = countTextView.GetComponent<Text>();

      var interactor = new Interactor(new Presenter(countTextView));

      // act: アクション実行
      interactor.CountUp();

      // assert: 検証
      Assert.That(text.text == "1");
    }
  }
}
