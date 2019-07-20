using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class indicator : MonoBehaviour {

    public GameObject correctimg;
    public GameObject wrongimg;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void correct ()
    {
        correctimg.SetActive(true);
        StartCoroutine("check");
    }

    IEnumerator check()
    {
        yield return new WaitForSeconds(0.5f);
        correctimg.SetActive(false);
    }

    public void wrong()
    {
        wrongimg.SetActive(true);
        StartCoroutine("nocheck");
    }

    IEnumerator nocheck()
    {
        yield return new WaitForSeconds(0.5f);
        wrongimg.SetActive(false);
    }

    public void runtimecorrect()
    {
        StartCoroutine("wait1");
        
    }

    IEnumerator wait1()
    {
        yield return new WaitForSeconds(2f);
        correct();
    }

    public void runtimewrong()
    {
        StartCoroutine("wait2");
        
    }

    IEnumerator wait2()
    {
        yield return new WaitForSeconds(2f);
        wrong();
    }

    public void nextGame(int loadlevel)
    {
        StartCoroutine(next(loadlevel));
    }

    IEnumerator next(int loadlevel)
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(loadlevel);
    }
}
