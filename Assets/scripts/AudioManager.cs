using UnityEngine;
using System;
using UnityEngine.Audio;


public class AudioManager : MonoBehaviour {

    public Sound[] Sounds;
    public static AudioManager instance;

	// Use this for initialization
	void Awake () {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sound s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.outputAudioMixerGroup = s.output;
            s.source.loop = s.loop;
        }
	}

  void Start()
    {
        Play("Musica");
    }

    public void Play(string Name)
    {
      Sound s = Array.Find(Sounds, sound => sound.Name == Name);
        if (s == null)
        {
            return;
        }

        s.source.Play();
    }
}
