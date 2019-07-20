using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goback : MonoBehaviour {

    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }
}
