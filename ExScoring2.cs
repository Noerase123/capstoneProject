using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExScoring2 : MonoBehaviour {

    public Text add;
    public Text add2;
    int score;
    int unScore;

    public void Score()
    {
        add.text = "" + score;
        score = score + 1;

       
            PlayerPrefs.SetInt("Exercise3", score);
        
    }

    public void UnScore()
    {
        add2.text = "" + unScore;
        unScore = unScore + 1;

            PlayerPrefs.SetInt("Exercise4", unScore);
        
    }

}
