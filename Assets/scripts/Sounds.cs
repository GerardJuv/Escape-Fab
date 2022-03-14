﻿using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]


public class Sound {
    public string Name;
    public AudioClip clip;


    [Range(0f, 1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;

    public bool loop;

    public AudioMixerGroup output;
}
