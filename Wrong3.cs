using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wrong3 : MonoBehaviour {

    public float score;
    public Text add;

    public void scoreManager()
    {
        add.text = "Wrong: " + score;
        score++;

        if (score > 0)
        {
            float wrong3;
            PlayerPrefs.SetFloat("ColorWrong3", score);

            wrong3 = PlayerPrefs.GetFloat("ColorWrong3") - 1;
            PlayerPrefs.SetFloat("ColorWrong3", wrong3);
        }

    }
}
