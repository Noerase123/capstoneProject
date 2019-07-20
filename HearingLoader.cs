using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HearingLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hearing1()
    {
        SceneManager.LoadScene(28);
    }

    public void Hearing2()
    {
        SceneManager.LoadScene(39);
    }

    public void Hearing3()
    {
        SceneManager.LoadScene(42);
    }

    public void Exercise()
    {
        SceneManager.LoadScene(31);
    }

    public void BackBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void learnings()
    {
        SceneManager.LoadScene(27);
    }
}
