﻿using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

public class ACSkill : SkillBase
{
    public PlayerStats playerRef;
    public MonsterManager monsterManagerRef;
    public MonsterBase currentMonster;
    public GameObject effect;
    public MonsterBase Boss;

    public float cooldownTime;
    public bool coolingDown = false;

    public event Action OnActivate;

    public void Awake()
    {
        monsterManagerRef.OnNew += MonsterIdentity;
        currentMonster = monsterManagerRef.currentMonster;
    }
    public void ACSkillButton()
    {
        StartCoroutine(ACActivated());
    }
    IEnumerator ACActivated()
    {
        if (!coolingDown)
        {
            if (cooldownTime <= 0)
            {
                coolingDown = true;
                cooldownTime = 10f;
                if (currentMonster != null)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        effect.SetActive(true);
                        yield return new WaitForSeconds(0.2f);
                        currentMonster.GetComponent<Health>().Change(playerRef.damage * 4);
                        effect.SetActive(false);
                        RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Torpedo", gameObject);

                        OnActivate?.Invoke();
                        yield return new WaitForSeconds(2f);
                    }
                    effect.SetActive(false);
                }
                else if(currentMonster == null)
                {
                    currentMonster = FindObjectOfType<MonsterBase>();
                    for (int i = 0; i < 3; i++)
                    {
                        effect.SetActive(true);
                        currentMonster.GetComponent<Health>().Change(playerRef.damage * 4);
                        yield return new WaitForSeconds(0.2f);
                        effect.SetActive(false);
                        RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Torpedo", gameObject);

                        OnActivate?.Invoke();
                        yield return new WaitForSeconds(2f);
                    }
                    effect.SetActive(false);
                }

                
                
            }
        }
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
        if (cooldownTime >= 0)
        {
            coolingDown = true;
            // this.GetComponent<Image>().color = Color.red;
        }
        if (cooldownTime <= 0)
        {
            coolingDown = false;
            // this.GetComponent<Image>().color = Color.white;
        }
    }

}
