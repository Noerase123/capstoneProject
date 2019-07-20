using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wrong2 : MonoBehaviour {

    public float score;
    public Text add;

    public void ScoreManager()
    {
        add.text = "Wrong: " + score;
        score++;

        if (score > 0)
        {
            float wrong2;
            PlayerPrefs.SetFloat("ColorWrong2", score);

            wrong2 = PlayerPrefs.GetFloat("ColorWrong2") - 1;
            PlayerPrefs.SetFloat("ColorWrong2", wrong2);
        }
    }
}
