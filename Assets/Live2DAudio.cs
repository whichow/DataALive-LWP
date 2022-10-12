using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live2DAudio : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    internal void PlayAudio(int index)
    {
        if(audioSource == null) return;
        if(index < 0 || index >= audioClips.Length) return;

        audioSource.clip = audioClips[index];
        audioSource.Play();
    }
}
