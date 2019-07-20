using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CatchNSum : MonoBehaviour {

    public Text scoreAdded;
    public Text scorePanel;

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;
    public AudioSource sound4;

    public int score = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
        scoreAdded.text = "" + PlayerPrefs.GetInt("add");
        scorePanel.text = "" + PlayerPrefs.GetInt("add");

	}

    
    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "PLUSFIVE")
        {
            score = score + 5;
            PlayerPrefs.SetInt("add", score);
            print(score);
            sound1.Play();

        }

        if (triggerCollider.tag == "PLUSTEN")
        {
            score = score + 10;
            PlayerPrefs.SetInt("add", score);
            print(score);
            sound2.Play();
        }

        if (triggerCollider.tag == "MINUSTWO")
        {
            score = score - 2;
            PlayerPrefs.SetInt("add", score);
            print(score);
            sound3.Play();
        }

        if (triggerCollider.tag == "MINUSTHREE")
        {
            score = score - 3;
            PlayerPrefs.SetInt("add", score);
            print(score);
            sound4.Play();
        }
    }

    
}
