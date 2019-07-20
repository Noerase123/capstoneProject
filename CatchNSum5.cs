using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CatchNSum5 : MonoBehaviour {

    public Text scoreAdded;
    public Text scorePanel;

    public int score = 0;

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;
    public AudioSource sound4;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
        scoreAdded.text = "" + PlayerPrefs.GetInt("add5");
        scorePanel.text = "" + PlayerPrefs.GetInt("add5");

	}

    
    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "PLUSTWENTY")
        {
            score = score + 20;
            PlayerPrefs.SetInt("add5", score);
            print(score);
            sound1.Play();
        }

        if (triggerCollider.tag == "PLUSTWENTYFIVE")
        {
            score = score + 25;
            PlayerPrefs.SetInt("add5", score);
            print(score);
            sound2.Play();
        }

        if (triggerCollider.tag == "MINUSTWENTYFIVE")
        {
            score = score - 25;
            PlayerPrefs.SetInt("add5", score);
            print(score);
            sound3.Play();
        }

        if (triggerCollider.tag == "MINUSTHIRTY")
        {
            score = score - 30;
            PlayerPrefs.SetInt("add5", score);
            print(score);
            sound4.Play();
        }
    }

    
}
