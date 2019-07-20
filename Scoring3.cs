using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring3 : MonoBehaviour {

    public float score;
    public Text add;

    public void ScoreManager()
    {
        
        add.text = "Score: " + score;
        score++;

        if (score > 0)
        {
            float colorfinal;

                PlayerPrefs.SetFloat("ColorScore3", score);
                PlayerPrefs.GetString("username10");

                colorfinal = PlayerPrefs.GetFloat("ColorScore3") - 1;
                PlayerPrefs.SetFloat("ColorScore3", colorfinal);
        }
    }
}
