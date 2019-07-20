using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashFade : MonoBehaviour {

    public Image splashImage;
    public int loadlevel;
    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(1.5f);
        FadeOut();
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(loadlevel);
    } 

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(0.5f, 1.0f, false);
    }
    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 1.5f, false);
    }

    
}
