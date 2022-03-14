using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options_Menu : MonoBehaviour {

    public AudioMixer VolumenMusic;
    public AudioMixer VolumenSound;


    public void SetVolumeM (float VolumeMusic)
    {
        VolumenMusic.SetFloat("VolumeMusic", VolumeMusic);
    }

    public void SetVolumeS(float VolumeSound)
    {
        VolumenSound.SetFloat("VolumeSound", VolumeSound); ;
    }

    public void ResetLVL()
    {
        PlayerPrefs.SetInt("levelReached", 1);
    }

}
