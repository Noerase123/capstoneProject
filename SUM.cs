using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SUM : MonoBehaviour {

    public Text quiztxt;

	// Use this for initialization
	void Start () {
        quiztxt.text = "" + PlayerPrefs.GetInt("quiz");
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
