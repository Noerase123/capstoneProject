using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundLearning : MonoBehaviour {

    public GameObject image;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject image7;
    public GameObject image8;
    public GameObject image9;
    public GameObject image10;

    public AudioSource sound;
    public AudioSource sound2;
    public AudioSource sound3;
    public AudioSource sound4;
    public AudioSource sound5;
    public AudioSource sound6;
    public AudioSource sound7;
    public AudioSource sound8;
    public AudioSource sound9;
    public AudioSource sound10;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void retina()
    {
        if (sound.isPlaying)
        {
            image.SetActive(true);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(false);
        }
        else if (image == true)
        {
            sound.Stop();
        }
    }

    public void optic()
    {
        if (sound2.isPlaying)
        {
            
            image.SetActive(false);
            image2.SetActive(true);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(false);

        }
    }

    public void VitreousHumor()
    {
        if (sound3.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(true);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(false);
        }
    }

    public void Sclera()
    {
        if (sound4.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(true);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(false);
        }
    }

    public void Cornea()
    {
        if (sound5.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(true);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(false);
        }
    }

    public void Pupil()
    {
        if (sound6.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(true);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(false);
        }
    }

    public void Lens()
    {
        if (sound7.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(true);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(false);
        }
    }

    public void Iris()
    {
        if (sound8.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(true);
            image9.SetActive(false);
            image10.SetActive(false);
        }
    }

    public void Body()
    {
        if (sound9.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(true);
            image10.SetActive(false);
        }
    }

    public void choroid()
    {
        if (sound10.isPlaying)
        {
            image.SetActive(false);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
            image5.SetActive(false);
            image6.SetActive(false);
            image7.SetActive(false);
            image8.SetActive(false);
            image9.SetActive(false);
            image10.SetActive(true);
        }
    }
}
