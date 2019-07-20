using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DragNDrop : MonoBehaviour {

    public Text score;
    float add = 1f;
    
    public Text attempts;
    float att = 4f;


    public GameObject Done;

    public GameObject check1;
    public GameObject check2;
    public GameObject check3;
    

    public GameObject drag;
    public GameObject drag2;
    public GameObject drag3;
    

    public GameObject one;
    public GameObject two;
    public GameObject three;
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Drag()
    {
        
        GameObject.Find("Drag").transform.position = Input.mousePosition;
        print("Uno");
       
    }

    public void Drag2()
    {
        GameObject.Find("Drag2").transform.position = Input.mousePosition;
        print("Dos");
    }

    public void Drag3()
    {
        GameObject.Find("Drag3").transform.position = Input.mousePosition;
        print("Tres");
    }


    public void Drop()
    {
        for (int i = 1; i <= 7; i++)
        {
            GameObject ph1 = GameObject.Find("PlaceHolder" + i);
            float distance = Vector3.Distance(GameObject.Find("Drag").transform.position, ph1.transform.position);
            print("Distance" + distance);
            if (distance < 75)
            {
                if (ph1.tag == "match")
                {
                    GameObject.Find("Drag").transform.position = ph1.transform.position;
                    
                    drag.SetActive(false);
                    one.SetActive(false);
                    check1.SetActive(true);
                    Done.SetActive(true);

                    score.text = "" + add;
                    add++;
                    Score();
                }
                else
                {
                    attempts.text = "" + att;
                    att--;

                    if (att == -1)
                    {
                        SceneManager.LoadScene(38);
                    }
                }
            }
        }
    }

    public void Drop2()
    {
        for (int i = 1; i <= 7; i++){
            GameObject ph2 = GameObject.Find("PlaceHolder" + i);
            float distance = Vector3.Distance(GameObject.Find("Drag2").transform.position, ph2.transform.position);
            print("Distance" + distance);
            if (distance < 75)
            {
                if (ph2.tag == "match2")
                {
                    GameObject.Find("Drag2").transform.position = ph2.transform.position;

                    drag2.SetActive(false);
                    two.SetActive(false);
                    check2.SetActive(true);
                    drag.SetActive(true);

                    score.text = "" + add;
                    add++;
                    Score();
                }
                else
                {
                    attempts.text = "" + att;
                    att--;

                    if (att == -1)
                    {
                        SceneManager.LoadScene(38);
                    }
                }

            }
        }
        
    }

    public void Drop3()
    {
        for (int i = 1; i <= 7; i++)
        {
            GameObject ph1 = GameObject.Find("PlaceHolder" + i);
            float distance = Vector3.Distance(GameObject.Find("Drag3").transform.position, ph1.transform.position);
            print("Distance" + distance);
            if (distance < 75)
            {
                if (ph1.tag == "match3")
                {
                    GameObject.Find("Drag3").transform.position = ph1.transform.position;
                    
                    drag3.SetActive(false);
                    three.SetActive(false);
                    check3.SetActive(true);
                    drag2.SetActive(true);

                    score.text = "" + add;
                    add++;
                    Score();
                }
                else
                {
                    attempts.text = "" + att;
                    att--;

                    if (att == -1)
                    {
                        SceneManager.LoadScene(38);
                    }
                }
            }
        }
    }

    void Score()
    {
        if (add > 0)
        {
            float clean;

            PlayerPrefs.SetFloat("CleanMeScore", add);
            PlayerPrefs.GetString("username15");

            clean = PlayerPrefs.GetFloat("CleanMeScore") - 1;
            PlayerPrefs.SetFloat("CleanMeScore", clean);
        }
    }

    
}   

