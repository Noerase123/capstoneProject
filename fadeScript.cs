using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeScript : MonoBehaviour {

    public Animator Anim;
    public Image Img;
    public int loadlevel;

    public void scene2()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        Anim.SetBool("Fade", true);
        yield return new WaitUntil(() => Img.color.a == 1);
        SceneManager.LoadScene(loadlevel);
    }
}
