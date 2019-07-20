using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int quiz;
    public Text quiztxt;

    public Text gameTimerText;
    public float gameTimer = 30f;
    public int loadlevel;

    /////////////////////////

    public Text ScoreText;
    float score = 10;
    public GameObject PerfectQuiz;
    public Text TotalScore;

    //////////////////////////
	
	// Update is called once per frame
	void Update () {
        gameTimer -= Time.deltaTime;

        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60);

        string timerString = string.Format("{0:0}:{1:00}", minutes, seconds);

        gameTimerText.text = timerString;

        if (gameTimer <= 0)
        {
            float points;
            points = score - 10;
            TotalScore.text = "" + points;
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
        ScoreText.text = "" + score;
        score = score + 10;

            if (score > 0)
            {
                float quiz1;

                PlayerPrefs.SetFloat("quiz1", score);
                PlayerPrefs.GetString("username6");

                quiz1 = PlayerPrefs.GetFloat("quiz1") - 10;
                PlayerPrefs.SetFloat("quiz1", quiz1);
            }
        
    }

    public void Quiztwo()
    {
        ScoreText.text = "" + score;
        score = score + 10;

            if (score > 0)
            {
                float quiz2;

                PlayerPrefs.SetFloat("quiz2", score);
                PlayerPrefs.GetString("username7");

                quiz2 = PlayerPrefs.GetFloat("quiz2") - 10;
                PlayerPrefs.SetFloat("quiz2", quiz2);
            }
        
    }

    public void button1()
    {
        quiztxt.text = "" + quiz;
        quiz = quiz + 4;
        PlayerPrefs.SetInt("quiz", quiz);
        print(quiz);
    }

    public void button2()
    {
        quiztxt.text = "" + quiz;
        quiz = quiz + 1;
        PlayerPrefs.SetInt("quiz", quiz);
        print(quiz);
    }

    public void button3()
    {
        quiztxt.text = "" + quiz;
        quiz = quiz + 5;
        PlayerPrefs.SetInt("quiz", quiz);
        print(quiz);
    }

    public void button4()
    {
        quiztxt.text = "" + quiz;
        quiz = quiz + 10;
        PlayerPrefs.SetInt("quiz", quiz);
        print(quiz);
    }

    public void button5()
    {
        quiztxt.text = "" + quiz;
        quiz = quiz + 8;
        PlayerPrefs.SetInt("quiz", quiz);
        print(quiz);
    }
}
