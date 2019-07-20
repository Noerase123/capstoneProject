using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour {

    public int loadlevel;

    public void onfinish()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(loadlevel);
    }
}
