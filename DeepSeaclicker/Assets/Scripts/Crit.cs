﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crit : MonoBehaviour
{
    public GameObject monster;
    public float critMultiplier;
    public Vector2[] critPos;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        GotHit(ChoosePos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ChoosePos()
    {
        return Random.Range(0, critPos.Length);
    }

    public void GotHit(int NewPos)
    {
        transform.position = new Vector3(monster.transform.position.x + critPos[NewPos].x,monster.transform.position.y +critPos[NewPos].y,-0.4f);
    }
}
