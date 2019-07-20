using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxTimer2 : MonoBehaviour {

    public GameObject timer;
    public GameObject player;
    public GameObject arrows;
    public Text gameTimerText;
    public float gameTimer;
    public int loadlevel;
    public GameObject gameover;
    public GameObject won;
    public GameObject won2;
    public GameObject lose;
    public GameObject pausebtn;


    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60);

        string timerString = string.Format("{0:0}:{1:00}", minutes, seconds);

        gameTimerText.text = timerString;

        if (gameTimer <= 0)
        {
            if(PlayerPrefs.GetInt("add2") == 400)
            {
                won.SetActive(true);
                won2.SetActive(true);
                lose.SetActive(false);
                gameover.SetActive(true);
                player.SetActive(false);
                timer.SetActive(false);
                pausebtn.SetActive(false);

            }
            else
            {
                gameover.SetActive(true);
                player.SetActive(false);
                timer.SetActive(false);
                pausebtn.SetActive(false);
            }
            
        }

        

        if (gameTimer <= 55)
        {
            arrows.SetActive(false);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Unpause()
    {
        Time.timeScale = 1;
    }

}
