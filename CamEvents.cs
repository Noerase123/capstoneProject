using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamEvents : MonoBehaviour {





    public Camera[] cams;

    public void firstcam()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;

    }

    public void secondcam()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;

    }
}
