using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// TODO: Bad implementation of audio manager. Need to redo later to control all audio sources.
/// </summary>
public class MusicPlayer : MonoBehaviour
{
    public GameObject musicObject;
    private float MusicVolume = 1f;
    private AudioSource AudioSource;

    private void Start()
    {
        musicObject = GameObject.FindWithTag("GameMusic");
        AudioSource = musicObject.GetComponent<AudioSource>();

        MusicVolume = PlayerPrefs.GetFloat("MusicVolume");
        AudioSource.volume = MusicVolume;
    }
    
    private void Update()
    {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("MusicVolume", MusicVolume);
    }

    public void updateVolume(float volume)
    {
        MusicVolume = volume;
    }
}
