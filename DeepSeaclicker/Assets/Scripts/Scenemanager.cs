using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    FMOD.Studio.Bus MasterBus;
    public ResetStats resetStats;

    public PlayerStats playerStats;
    // Start is called before the first frame update
    private void Start()
    {
        MasterBus = FMODUnity.RuntimeManager.GetBus("Bus:/");
    }

    public void PlayGame()
    {
    
        SceneManager.LoadScene("Overworld");
        MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);

        if (resetStats.paths == null)
        {
            resetStats.Reset();
        }
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void SaveGame()
    {
        playerStats.SaveStats();
        SceneManager.LoadScene("Overworld");
        MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }  
}
