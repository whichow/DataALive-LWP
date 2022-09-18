﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] clips;

    private AudioSource source;
    int index;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void EnableVolume(bool enable)
    {
        if(enable)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

    public void EnableMusic(bool enable)
    {
        if(enable)
        {
            source.mute = false;
        }
        else
        {
            source.mute = true;
        }
    }

    public void ChangeMusic()
    {
        if (++index >= clips.Length)
            index = 0;
        source.clip = clips[index];
        source.Play();
    }
}
