using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameControler : MonoBehaviour
{
    public static GameControler instance;
    public Text countdownValue;
    private int Countdown = 1800;                 
    public GameObject gameOvertext;               
    public bool gameOver = false;
    public int gameStatus = 1;
   

    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }

    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            // TODO LOAD MENU 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void CountDown()
    {
        if (gameOver)
            return;
        Countdown--;
        //...and adjust the score text.
        countdownValue.text = countdownValue.ToString();
    }

    public void timeUp()
    {
        gameOvertext.SetActive(true);
        gameOver = true;
    }
}