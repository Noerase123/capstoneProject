using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColorTimer : MonoBehaviour {
    
    public Text gameTimerText;
    public float gameTimer = 30f;
    public int loadlevel;

   
	
	// Update is called once per frame
	void Update () {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60);

        string timerString = string.Format("{0:0}:{1:00}", minutes, seconds);

        gameTimerText.text = timerString;

        if (gameTimer <= 0)
        {
            SceneManager.LoadScene(loadlevel);
        }
	}

    public void Unpause()
    {
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

   
    
}
