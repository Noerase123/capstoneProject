using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour{

    public float score;
    public float diffscore;
    public float diffscore2;
    public float diffscore3;
    public Text add;

    public void scoreManager()
    {
        add.text = "Score: " + score;
        score++;

        if (score > 0)
        {
            float colorFinal;
                
                PlayerPrefs.SetFloat("ColorScore1", score);
                PlayerPrefs.GetString("username8");

                colorFinal = PlayerPrefs.GetFloat("ColorScore1") - 1;
                PlayerPrefs.SetFloat("ColorScore1", colorFinal);
                
           
        }
    }

    public void Difference()
    {

        add.text = "Score: " + diffscore;
        diffscore++;

        if (diffscore > 0)
        {
            float colordiff;

            PlayerPrefs.SetFloat("diff", diffscore);
            PlayerPrefs.GetString("diffname");

            colordiff = PlayerPrefs.GetFloat("diff") - 1;
            PlayerPrefs.SetFloat("diff", colordiff);
        }

    }

    public void Difference2()
    {
 
        add.text = "Score: " + diffscore2;
        diffscore2++;

        if (diffscore2 > 0)
        {
            float colordiff;

                PlayerPrefs.SetFloat("diff2", diffscore2);
                PlayerPrefs.GetString("diffname");

                colordiff = PlayerPrefs.GetFloat("diff2") - 1;
                PlayerPrefs.SetFloat("diff2", colordiff);
        }
        
    }

    public void Difference3()
    {
        
        add.text = "Score: " + diffscore3;
        diffscore3++;

        if (diffscore3 > 0)
        {
            float colordiff;

                PlayerPrefs.SetFloat("diff3", diffscore3);
                PlayerPrefs.GetString("diffname");

                colordiff = PlayerPrefs.GetFloat("diff3") - 1;
                PlayerPrefs.SetFloat("diff3", colordiff);
        }
        
    }


}
