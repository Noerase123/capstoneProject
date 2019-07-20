using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreScript : MonoBehaviour {

    public int points;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score :" + points);
        
    }
}
