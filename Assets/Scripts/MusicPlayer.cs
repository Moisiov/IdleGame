using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// TODO: Bad implementation of audio manager. Need to redo later to control all audio sources.
/// </summary>
public class MusicPlayer : MonoBehaviour
{
    public AudioSource AudioSource;

    private float musicVolume = 1f;
    void Start()
    {
        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        AudioSource.Play();
    }
    
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
