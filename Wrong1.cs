using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wrong1 : MonoBehaviour {

    public float score;
    public Text add;

    public void scoreManager()
    {
        add.text = "Wrong: " + score;
        score++;

        if (score > 0)
        {
            float wrong;
            PlayerPrefs.SetFloat("ColorWrong1", score);
            wrong = PlayerPrefs.GetFloat("ColorWrong1") - 1;
            PlayerPrefs.SetFloat("ColorWrong1", wrong);
        }
        else if (score == 0)
        {
            score = 0;
        }
    }
}
