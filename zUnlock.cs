using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class zUnlock : MonoBehaviour {

    public GameObject unlockable;

	// Use this for initialization
	void Start () {
        GameObject.Find("Unlock");
	}
	
	// Update is called once per frame
	void Update () {
        
	}


    public void LevelUnlock()
    {
       GameObject.Find("Unlock").SetActive(false);
    }
}
