using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour {

    private music music;
    public Button musicToggleButton;
    public GameObject musicOnSprite;
    public GameObject musicOffSprite;

    void Start()
    {
        music = FindObjectOfType<music>();
        UpdateIcon();
    }

    public void PauseMusic()
    {
        music.ToggleSound();
        UpdateIcon();
    }

    void UpdateIcon()
    {
        if (PlayerPrefs.GetInt("Muted", 0) == 0)
        {
            AudioListener.volume = 1;
            musicOnSprite.SetActive(true);
            musicOffSprite.SetActive(false);
        }
        else
        {
            AudioListener.volume = 0;
            musicOffSprite.SetActive(true);
            musicOnSprite.SetActive(false);
        }
    }

    public void musicpls()
    {
        music.BackgroundMusic();
        AudioListener.volume = 1;
    }

    public void musicLoad()
    {
        music.SoloMusic();
        music.ToggleSound();
        AudioListener.volume = 1;
    }


    
}
