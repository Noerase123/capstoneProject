using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxScript : MonoBehaviour {

    public Button Level02Btn, Level03Btn;
    int levelPassed;

	// Use this for initialization
	void Start () {
        levelPassed = PlayerPrefs.GetInt("levelPassed");
        Level02Btn.interactable = false;
        Level03Btn.interactable = false;

        switch (levelPassed)
        {
            case 1:
                Level02Btn.interactable = true;
                break;
            case 2:
                Level02Btn.interactable = true;
                Level03Btn.interactable = true;
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

}
