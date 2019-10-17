using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeframe : MonoBehaviour
{
    private bool startTimer;
    private float timer;
    private float startRecording;

    public List<KeyFrame> KeyFrames;
    // Start is called before the first frame update
    void Start()
    {
        timer = 6f;
        startTimer = false;
        KeyFrames = new List<KeyFrame>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTimer = true;
            timer = 0f;
        }

        if (startTimer)
        {
            timer += Time.deltaTime;
        }

        if (timer < 5)
        {
            if (Input.GetMouseButtonDown(0))
            {
                KeyFrames.Add(new KeyFrame(timer));
                Debug.Log(timer);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            KeyFrames.Clear();
        }

        if (Input.GetKeyDown((KeyCode.P)))
        {
            
            
        }
    }
    
   
}
[Serializable]
public class KeyFrame
{
    public KeyFrame(float time)
    {
        this.time = time;
    }
    public float time;
}