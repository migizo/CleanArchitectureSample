using UnityEngine;
using UnityEngine.UI;
using Zenject;


public class CountButton : MonoBehaviour
{
  Controller controller;
  public int testCount = 0;

  public void Constructor(Controller controller)
  {
    this.controller = controller;
  }
  void Start()
  {
    GetComponent<Button>().onClick.AddListener(ClickEvent);
  }
  void OnDestroy()
  {
    GetComponent<Button>().onClick.RemoveListener(ClickEvent);
  }

  void ClickEvent()
  {
    controller.CountUp();
    testCount++;
  }
}
