using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class links : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void senseOfSight()
    {
        Application.OpenURL("http://eschooltoday.com/science/the-five-senses/the-sense-of-sight.html");
    }

    public void PreventEyesProblem()
    {
        Application.OpenURL("https://www.healthline.com/health/eye-health-disease-prevention#1");
    }

    public void BestFoods()
    {
        Application.OpenURL("https://www.healthline.com/health/eye-health/best-foods-for-eyes");
    }

    public void Importance()
    {
        Application.OpenURL("https://www.zeiss.com/vision-care/int/better-vision/health-prevention/why-good-vision-is-so-important-.html");
    }

    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=avJ4xyMw-eA&t=31s");
    }

    public void BGmusic()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=0bI3bd40q6w");
    }
    
}
