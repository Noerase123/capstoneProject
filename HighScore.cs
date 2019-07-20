using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreToAll : MonoBehaviour {

    public Text quizScore;
    private int score;

    // Use this for initialization
    void Start()
    {
        quizScore.text = "" + ((int)PlayerPrefs.GetFloat("QuizShapes")).ToString();
        quizScore.text = "" + ((int)PlayerPrefs.GetFloat("QuizColors")).ToString();
        quizScore.text = "" + ((int)PlayerPrefs.GetFloat("Colors1")).ToString();
        quizScore.text = "" + ((int)PlayerPrefs.GetFloat("Colors2")).ToString();
        quizScore.text = "" + ((int)PlayerPrefs.GetFloat("Colors3")).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuizShapes()
    {
        score = score + 10;

        PlayerPrefs.SetFloat("QuizShapes", score);

        SceneManager.LoadScene(4);
    }

    public void QuizColors()
    {
        score = score + 10;

        PlayerPrefs.SetFloat("QuizColors", score);

        SceneManager.LoadScene(4);
    }

    public void ColorReaction1()
    {
        score = score + 10;

        PlayerPrefs.SetFloat("Colors1", score);

        SceneManager.LoadScene(7);
    }

    public void ColorReaction2()
    {
        score = score + 10;

        PlayerPrefs.SetFloat("Colors2", score);

        SceneManager.LoadScene(7);
    }

    public void ColorReaction3()
    {
        score = score + 10;

        PlayerPrefs.SetFloat("Colors3", score);

        SceneManager.LoadScene(7);
    }
    
}
