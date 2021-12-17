using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterScripts : MonoBehaviour
{
    public TextMeshProUGUI counterMessage;
    private string screenText;
    private int counter = 5;
    private float seconds = 1.5f;

    void Start()
    {
        StartCoroutine("showCounter");

    }

    private IEnumerator showCounter()
    {
        while (counter >=0)
        {
            screenText = counter.ToString();
            counterMessage.text = screenText;
            counter--;
            yield return new WaitForSeconds(seconds);
        }
        screenText = "Fin";
        counterMessage.text = screenText;
    }
  
}
