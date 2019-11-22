﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float goldAmount;
    private float DamageLevel;
    public float damage;
    public float cost;
    private int goldMuiltiplayer;
    private float goldgain;

    private float _newCost;
    public MonsterManager monsterManger;
    
    
    // Start is called before the first frame update
    void Start()
    {
        monsterManger.Onleave += MonsterMangerOnOnleave;
        goldMuiltiplayer = 10;
        
        goldAmount = 100000;

    }

    private void MonsterMangerOnOnleave(MonsterBase obj)
    {
        goldAmount += CalcGold(obj.reward);
        
    }

    // Update is called once per frame
    void Update()
    {
        goldgain = Mathf.Round(MonsterManager.monsterLevel * 2.8f + (9f));
    }

    public void upgradestats()
    {
        Debug.Log(goldAmount);
        if (goldAmount >= cost)
        {
            
            goldAmount -= cost;
            damage = Mathf.Round(damage * 1.3f);
            cost = Mathf.Round(cost * 1.3f);
            cost = Mathf.Round(cost * 1.3f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
            Debug.Log(damage);
        }
   
    }
    
    private int CalcGold(int reward)
    {
        return  goldMuiltiplayer * reward;
    }


}
