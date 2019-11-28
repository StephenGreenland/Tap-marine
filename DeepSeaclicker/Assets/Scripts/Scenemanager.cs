﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    FMOD.Studio.Bus MasterBus;

    public PlayerStats playerStats;
    // Start is called before the first frame update
    private void Start()
    {
        MasterBus = FMODUnity.RuntimeManager.GetBus("Bus:/");
    }

    public void PlayGame()
    {
        MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        SceneManager.LoadScene("Overworld");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SaveGame()
    {
        playerStats.SaveStats();
        SceneManager.LoadScene("Overworld");
    }  
}
