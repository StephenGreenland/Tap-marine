using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volcanoboss : MonsterBase
{
    FMOD.Studio.Bus MasterBus;
    public Health health;
    public string sceneToLoad;
    private void OnEnable()
    {

        health.OnChanged += OnHealthChanged;
        MasterBus = FMODUnity.RuntimeManager.GetBus("Bus:/");
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Enemies/BossJelly", gameObject);
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