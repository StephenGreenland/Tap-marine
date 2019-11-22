﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarpoonSkill : MonoBehaviour
{
    public PlayerStats playerRef;
    public MonsterManager monsterManagerRef;
    public MonsterBase currentMonster;

    public float cooldownTime;
    public bool coolingDown = false;

    private Color initColor;

    public void Awake()
    {
        initColor = this.GetComponent<Image>().color;
        monsterManagerRef.OnNew += MonsterIdentity;
        currentMonster = monsterManagerRef.currentMonster;
        
    }
    public void HarpoonActivated()
    {
        if (!coolingDown)
        {
            if (cooldownTime <= 0)
            {
                currentMonster.GetComponent<Health>().Change(playerRef.damage * 5);
                coolingDown = true;
                cooldownTime = 5f;
            }
        }
        /*if (skillActive) return;
        skillActive = true;
        if (skillActive)

        {
            //adding 5 times the amount of base damage to base damage. This is so that Harpoon Damage scales with base damage
            player.damage += 5* (player.damage);

        }*/
    }
    public void MonsterIdentity(MonsterBase obj)
    {
        currentMonster = obj;
        
    }

    private void OnDestroy()
    {
        monsterManagerRef.OnNew -= MonsterIdentity;
    }
    public void Update()
    {
        cooldownTime -= Time.deltaTime;
        if (cooldownTime <= 0)
        {
            coolingDown = false;
        }

        if (coolingDown)
        {
            this.GetComponent<Image>().color = Color.gray;

        }
        if (!coolingDown)
        {
            this.GetComponent<Image>().color = initColor;
        }
    }
}
