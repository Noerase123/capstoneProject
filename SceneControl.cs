using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControl : MonoBehaviour {

    int sceneIndex;
    public GameObject Exit;

	// Use this for initialization
	void Start () {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Exit.SetActive(true);
	}

    
}
