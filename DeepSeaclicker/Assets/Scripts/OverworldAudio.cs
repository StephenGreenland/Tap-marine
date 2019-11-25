using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldAudio : MonoBehaviour
{
    public OW_WhirlPool WhirlPoo;
    FMOD.Studio.EventInstance OVWTrack1;
    FMOD.Studio.EventInstance Movement;
    void Start()
    {
      
        
        //SubMovement
        Movement = FMODUnity.RuntimeManager.CreateInstance("event:/Player/Movement/OverworldMovement");
        Movement.start();
        Movement.release();
        
        //Music
        OVWTrack1 = FMODUnity.RuntimeManager.CreateInstance("event:/Music/Overworld");
        OVWTrack1.start();
        OVWTrack1.release();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Player/Movement/Sonar", gameObject);
        }

       
        //SubMovement
        if (Input.GetMouseButtonDown(0))
        {
            Movement.setParameterByName("PitchShift", 1f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Movement.setParameterByName("PitchShift", 0f); 
        }
    }
}
