using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour {

    static music instance = null;

    public AudioSource myMusic;

    public AudioSource mainMusic;

    private SoundScript sound;

    public GameObject BGM;

    void Update()
    {

    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
    }


    public void BackgroundMusic()
    {
        myMusic.volume = (float)0.001;
    }

    public void SoloMusic()
    {
        myMusic.volume = 1;
    }

	
}
