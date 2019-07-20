using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VisionScript : MonoBehaviour {

  
    public void QuizGame()
    {
        SceneManager.LoadScene(4);
    }

    public void TheFalling()
    {
        SceneManager.LoadScene(11);
    }

    public void FirstFalling()
    {
        SceneManager.LoadScene(5);
    }

    public void MatchingColor()
    {
        SceneManager.LoadScene(6);
    }

    public void ColorReaction()
    {
        SceneManager.LoadScene(7);
    }

    public void FirstColorReaction()
    {
        SceneManager.LoadScene(34);
    }

    public void BackBtn()
    {
        SceneManager.LoadScene(5);
    }

   

    
}
