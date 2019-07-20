using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring2 : MonoBehaviour {

    public float score;
    public Text add;

    public void ScoreManager()
    {
        add.text = "Score: " + score;
        score++;

        if (score > 0)
        {
            float colorfinal;

                PlayerPrefs.SetFloat("ColorScore2", score);
                PlayerPrefs.GetString("username9");

                colorfinal = PlayerPrefs.GetFloat("ColorScore2") - 1;
                PlayerPrefs.SetFloat("ColorScore2", colorfinal);
        }
    }
}
