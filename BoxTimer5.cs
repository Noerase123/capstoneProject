using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxTimer5 : MonoBehaviour {

    
    public GameObject arrows;
    public Text gameTimerText;
    public float gameTimer;
    public int loadlevel;
    


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
            if(PlayerPrefs.GetInt("add5") == 600)
            {
                SceneManager.LoadScene(loadlevel);
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
