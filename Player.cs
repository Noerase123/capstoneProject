using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {


    public Button LeftBtn;
    public Button RightBtn;

    public void firstcam()
    {
        LeftBtn.enabled = true;
        RightBtn.enabled = false;
        

    }

    public void secondcam()
    {
        LeftBtn.enabled = false;
        RightBtn.enabled = true;

    }
}
