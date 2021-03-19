﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource AudioSource;
    public float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void updateVolume(float volume){
        musicVolume = volume;

    }

    public void mute(){
        AudioListener.pause = !AudioListener.pause;
    }
    public void unmute(){
        musicVolume = 1;
    }
}
