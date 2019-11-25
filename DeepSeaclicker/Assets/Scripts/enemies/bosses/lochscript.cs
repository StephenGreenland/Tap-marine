using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lochscript : MonsterBase
{
    FMOD.Studio.Bus MasterBus;
    public Health health;
    public string sceneToLoad;
    private void OnEnable()
    {
        health.OnChanged += OnHealthChanged;
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Enemies/Lockness", gameObject);
        MasterBus = FMODUnity.RuntimeManager.GetBus("Bus:/");
    }

    private void OnDisable()
    {
        health.OnChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float amount)
    {

        if (health.amount <= 0)
        {
            OnLeave();
            Destroy(gameObject);
            SceneManager.LoadScene(sceneToLoad);
            MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT); 
        }
    }
}
