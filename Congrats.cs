using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congrats : MonoBehaviour {

    public GameObject menu;
    public float second;

	// Use this for initialization
	void Start () {
        menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Lazy());
	}

    IEnumerator Lazy()
    {
        yield return new WaitForSeconds(second);
        menu.SetActive(true);
    }
}
