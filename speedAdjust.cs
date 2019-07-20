using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedAdjust : MonoBehaviour {

    public GameObject NextLevelBtn;
    public float goal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void NextLevel1()
    {
        NextLevelBtn.SetActive(false);
        StartCoroutine("LevelUp");
    }

    IEnumerator LevelUp()
    {
        yield return new WaitForSeconds(10);
        NextLevelBtn.SetActive(true);
    }
}
