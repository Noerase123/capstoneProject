using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class plusScore : MonoBehaviour {

    public GameObject points;
    public GameObject PlusPoints;
    public int score;
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (points.activeSelf)
        {
            Time.timeScale = 0;
        }
	}

    public void gamePoints()
    {
        PlusPoints.SetActive(true);
        
        StartCoroutine("WaitingSeconds");
        
    }

    IEnumerator WaitingSeconds()
    {
        yield return new WaitForSeconds(1);
        
        PlusPoints.SetActive(false); 
    }


    public void StartWith()
    {
        points.SetActive(false);
        Time.timeScale = 1;
    }
}
