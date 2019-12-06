using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hydra : MonsterBase
{
    public MonsterManager fixenemy;
    FMOD.Studio.Bus MasterBus;
    public Health health;
    public string sceneToLoad;
    public Scenemanager scenemanager;
   
    
    private void OnEnable()
    {
        MasterBus = FMODUnity.RuntimeManager.GetBus("Bus:/");
        health.OnChanged += OnHealthChanged;
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Enemies/BossHydra", gameObject);

    }
    private void OnDisable()
    {
        health.OnChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float amount)
    {

        if (health.amount <= 0)
        {

            Destroy(gameObject);
            OnLeave();
            scenemanager.SaveGame();

            MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            fixenemy.monsterLevel = 0;
      

          
        }
    }
}
