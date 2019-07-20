using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelUnlocked : MonoBehaviour {

    public GameObject unlocked;
    public Text done;

	// Use this for initialization
	void Start () {
        done.text = "" + PlayerPrefs.GetInt("levelup");
        unlocked.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
            unlocked.SetActive(false);
	}

    
}
