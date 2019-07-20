using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void VisionScript()
    {
        SceneManager.LoadScene(2);
    }

    public void HearingScript()
    {
        SceneManager.LoadScene(48);
    }
    
}
