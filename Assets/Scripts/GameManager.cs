using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject box;
    public GameObject hud;
    public Button startButton;
    public Timer timer;
    public bool isGameRunning;

    void Start()
    {
        timer = gameObject.GetComponent<Timer>();
    }

    // Update is called once per frame
    public void StartGame()
    {
        isGameRunning = true;
        timer.Begin();
        player.SetActive(true);
        box.SetActive(true);
        hud.SetActive(true);
        startButton.gameObject.SetActive(false);

        if (timer.timeRemaining <= 0 )
        {
            isGameRunning = false;
            player.SetActive(false);
            box.SetActive(false);
            hud.SetActive(false);
            startButton.gameObject.SetActive(true);
        }
    }

}
