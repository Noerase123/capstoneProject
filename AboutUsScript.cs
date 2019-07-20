using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutUsScript : MonoBehaviour {

    public float speed = 5f;
    public GameObject AboutUs;

	// Use this for initialization
	void Start () {
        transform.Translate(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, 0);
        StartCoroutine(startup());
        StartCoroutine(TheEnd());
	}

    IEnumerator startup()
    {
        yield return new WaitForSeconds(1);
        transform.Translate(0, speed, 0);   
    }

    IEnumerator TheEnd()
    {
        yield return new WaitForSeconds(10);
        transform.Translate(0, 0, 0);
        AboutUs.SetActive(false);
        
    }

    
}
