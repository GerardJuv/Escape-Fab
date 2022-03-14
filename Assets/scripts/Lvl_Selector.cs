using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lvl_Selector : MonoBehaviour {
    public Button[] Levelbuttons;


    // Use this for initialization
    void Start () {
        int LevelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < Levelbuttons.Length; i++)
        {
            if (i + 1 > LevelReached)
                Levelbuttons[i].interactable = false;
        }
    }
    public void GoLVL1()
    {
        SceneManager.LoadScene("2-Lvl1");
    }

    public void GoLVL2()
    {
        SceneManager.LoadScene("3-Lvl2");
    }

    public void GoLVL3()
    {
        SceneManager.LoadScene("4-Lvl3");
    }

}
