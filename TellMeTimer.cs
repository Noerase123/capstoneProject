using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TellMeTimer : MonoBehaviour {

    public Text gameTimerText;
    public float gameTimer = 30f;
    public int loadlevel;

    /////////////////////////

    public Text ScoreText;
    float score;
    public GameObject PerfectQuiz;
    public Text TotalScore;

    //////////////////////////

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
            SceneManager.LoadScene(loadlevel);
            TotalScore.text = "" + score;
            PerfectQuiz.SetActive(true);

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

    public void Quiz()
    {
        ScoreText.text = "0" + score;
        score = score + 10;

        PlayerPrefs.SetFloat("quiz1", score);

    }

    public void Quiztwo()
    {
        ScoreText.text = "0" + score;
        score = score + 10;

        PlayerPrefs.SetFloat("quiz2", score);
    }
}
