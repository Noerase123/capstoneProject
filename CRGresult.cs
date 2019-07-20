using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CRGresult : MonoBehaviour {
    public GameObject btn;
    public GameObject btn2;
    public GameObject result;
    public GameObject linearTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (result)
        {
            Time.timeScale = 0;
            Destroy(btn);
            btn2.SetActive(true);
            linearTimer.SetActive(false);
        }
	}
}
