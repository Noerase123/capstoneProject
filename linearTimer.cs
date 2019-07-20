using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class linearTimer : MonoBehaviour {

    public Image timeBar;
    public float maxTime = 30f;
    float timeleft;
    public int loadlevel;
    
	// Use this for initialization
	void Start () {
        timeBar = GetComponent<Image>();
        timeleft = maxTime;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timeBar.fillAmount = timeleft / maxTime;
        }
        if (timeBar.fillAmount == 0)
        {
            SceneManager.LoadScene(loadlevel);
        }
        
	}

    
}
