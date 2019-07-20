using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wrong : MonoBehaviour {
    
    public Image lifeone;
    public Image lifetwo;
    public Image lifethree;
    public int loadlevel;

    public void lostlife()
    {
        if (lifethree)
        {
            Destroy(lifethree);
        }
        else if (lifetwo)
        {
            Destroy(lifetwo);
        }
        else
        {
            Destroy(lifeone);
            SceneManager.LoadScene(loadlevel);
        }
    }
}
