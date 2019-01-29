using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Countdown countdown;

    public Text tCountdown;


    public void Start()
    {
       
       setCountdown();
    }

    public void Update()
    {
        tCountdown.text = countdown.initialCounter.ToString("f0");

        if (countdown.initialCounter < 1)
        {
            tCountdown.enabled = false;

        }
        setCountdown();
    }

    private void setCountdown()
    {
        tCountdown.text = countdown.initialCounter.ToString("f0");

        if (countdown.initialCounter < 0)
        {
            tCountdown.enabled = false;

        }
      

    }
}
