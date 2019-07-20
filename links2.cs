using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class links2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SenseOfHearing()
    {
        Application.OpenURL("http://eschooltoday.com/science/the-five-senses/the-sense-of-hearing.html");
    }

    public void HearingLoss()
    {
        Application.OpenURL("https://www.mayoclinic.org/diseases-conditions/hearing-loss/symptoms-causes/syc-20373072");
    }

    public void HearingFoods()
    {
        Application.OpenURL("https://naroaudiology.com/blog/top-4-foods-for-healthy-ears-");
    }

    public void HearingPrevention()
    {
        Application.OpenURL("https://www.webmd.com/cold-and-flu/ear-infection/tips-prevent-ear-infections#2");
    }

    public void HearingImportance()
    {
        Application.OpenURL("https://bellman.com/en/your-hearing/facts-about-hearing/");
    }

    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=2bDnssOmK9k");
    }
}
