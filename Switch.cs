using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour {

    public int load;
    public GameObject loadingObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void CatSwitch()
    {
        StartCoroutine("SwitchC");
    }

    IEnumerator SwitchC()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(load);
    }

    public void LoadingGame(int sceneIndex)
    {
        Time.timeScale = 1;
        loadingObject.SetActive(true);
        StartCoroutine(Loading(sceneIndex));
    }

    IEnumerator Loading(int sceneIndex)
    {
        yield return new WaitForSeconds(1.5f);
       
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        Time.timeScale = 1;

        while (!operation.isDone)
        {
            float progress = Mathf.RoundToInt(operation.progress / .9f);
            yield return null;
        }
    }


    
}
