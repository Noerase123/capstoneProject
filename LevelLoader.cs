using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    public GameObject LoadingScreen;
    public Slider slider;
    public Text ProgressText;

    public GameObject LoadingObject;
    public int nextscene;


	public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
	
    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        LoadingScreen.SetActive(true);
        Time.timeScale = 1; 

        while (!operation.isDone)
        {
            float progress = Mathf.RoundToInt(operation.progress / .9f);

            slider.value = progress;
            ProgressText.text = progress * 100.00f + "%";

            yield return null;
        }
    }
}
