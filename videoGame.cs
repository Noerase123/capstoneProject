using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("start");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator start()
    {
        yield return new WaitForSeconds(65);

        SceneManager.LoadScene(49);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
    }
}
