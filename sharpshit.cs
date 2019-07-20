using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sharpshit : MonoBehaviour {

    public int loadlevel;

    public void Loadershit(int sceneIndex)
    {
        SceneManager.LoadScene(loadlevel);
    }

    
}
