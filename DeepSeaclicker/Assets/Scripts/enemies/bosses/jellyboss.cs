using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class jellyboss : MonsterBase

{
    public MonsterManager fixenemy;
    FMOD.Studio.Bus MasterBus;
    public Health health;
    public string sceneToLoad;
    public Scenemanager scenemanager;
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
            Destroy(gameObject);
            OnLeave();
            scenemanager.SaveGame();
           
         
            MasterBus.stopAllEvents(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            fixenemy.monsterLevel = 0;
        }
    }
}
