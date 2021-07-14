using UnityEngine;
using UnityEngine.UI;

public class CountTextView : MonoBehaviour, IView
{
  public void UpdateText(string text)
  {
    GetComponent<Text>().text = text;
  }
}
