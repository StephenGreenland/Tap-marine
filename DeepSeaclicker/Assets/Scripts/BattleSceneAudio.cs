using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneAudio : MonoBehaviour
{
    public MonsterManager MonsterManager;
    FMOD.Studio.EventInstance BattleTrack1;
    private void Start()
    {    
        MonsterManager.Onleave += MonsterManager_Onleave;
        MonsterManager.OnNew += MonsterManager_OnNew;

        BattleTrack1 = FMODUnity.RuntimeManager.CreateInstance("event:/Music/BattleMusic");
        BattleTrack1.start();
    }

    //Monster Spawn Sound
    private void MonsterManager_OnNew(MonsterBase obj)
    {

        //obj.GetComponent<Health>().OnChanged += BattleSceneAudio_OnChanged
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Enemies/MonsterSpawn", gameObject);
    }

    //Monster Death Sound
    private void MonsterManager_Onleave(MonsterBase obj)
    {
        FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Enemies/MonsterDeath", gameObject);
    }

    private void OnDestroy()
    {
        MonsterManager.Onleave -= MonsterManager_Onleave; 
        MonsterManager.OnNew -= MonsterManager_OnNew; 
    }
    void Update()
    {
        //Main Cannon
        if (Input.GetMouseButtonDown(0))
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Cannon", gameObject);
        }

        //Harpoon TEST
        if (Input.GetKeyDown(KeyCode.K))
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Harpoon", gameObject);
        }
        
        //Torpedo TEST
        if (Input.GetKeyDown(KeyCode.L))
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Torpedo", gameObject);
        }
    }
}
