using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class randomize : MonoBehaviour {
    
    public GameObject[] objectPool;
    private int currentIndex = 0;
	
    // Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void NewRandomObject()
    {
        int newIndex = Random.Range(0, objectPool.Length);
        objectPool[currentIndex].SetActive(false);
        currentIndex = newIndex;
        objectPool[currentIndex].SetActive(true);
        
    }


    public void ColorRandom()
    {
        StartCoroutine("Loading");
    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(2.5f);
        int newIndex = Random.Range(0, objectPool.Length);
        objectPool[currentIndex].SetActive(false);
        currentIndex = newIndex;
        objectPool[currentIndex].SetActive(true);
    }

}
