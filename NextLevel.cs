using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public int CoinsToUnlocked;
    public GameObject Next_Level;
    public int max_level;
    public string num_level;
    public GameObject panel;
    public static int thelevel;
    public int t;

	// Use this for initialization
	void Start () {
        thelevel = PlayerPrefs.GetInt("thelevel", thelevel);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
