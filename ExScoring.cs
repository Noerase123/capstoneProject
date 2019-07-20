using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExScoring : MonoBehaviour{

    
    int score;
    int unscore;
    public Text add;
    public Text add2;

    public void scoreManager()
    {
        add.text = "" + score;
        score = score + 1;

            PlayerPrefs.SetInt("Exercise1", score);
        
    }

    public void UnScore()
    {
        add2.text = "" + unscore;
        unscore = unscore + 1;

            PlayerPrefs.SetInt("Exercise2", unscore);
        

    }
}
