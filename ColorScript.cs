﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
   
        if (other.name == "Player")
        {
            
            other.GetComponent<ScoreScript>().points++;
            //add 1 to points
            Destroy(gameObject); // this destroy things
        }
        
    }
}
