using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int duration = 30;
    public int timeRemaining;
    public bool isCountingDown;

    public Text timerText;

    void Start()
    {

    }
    public void Update()
    {
        timerText.text = "Time: " + timeRemaining;
    }

    public void Begin()
    {
        if (!isCountingDown) 
        { 
            isCountingDown = true;
            timeRemaining = duration;

            Invoke("Tick", 1);
        }
    }

    public void Tick()
    {
        timeRemaining--;
        if (timeRemaining > 0)
        {
            Invoke("Tick", 1);
        }
        else
        {
            isCountingDown = false;
        }
    }
}
