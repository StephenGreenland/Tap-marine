using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarpoonSkill : MonoBehaviour
{
    public PlayerStats playerRef;
    public MonsterManager monsterManagerRef;
    public MonsterBase currentMonster;
    public GameObject harpoon;

    public float cooldownTime;
    public bool coolingDown = true;

    private Color initColor;

    
    public event Action OnActivate;
    
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
                FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Player/Weapons/Harpoon", gameObject);
                harpoon.SetActive(false);
                coolingDown = true;
                currentMonster.GetComponent<Health>().Change(playerRef.damage * 5);
                cooldownTime = 5f;
                
                OnActivate?.Invoke();
                // ActivateEvent();
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
        if (cooldownTime >= 0)
        {
         
            coolingDown = true;
            this.GetComponent<Image>().color = Color.gray;
            harpoon.SetActive(false);
        }
        if (cooldownTime <= 0)
        {
            coolingDown = false;
            this.GetComponent<Image>().color = initColor;
            harpoon.SetActive(true);
        }
    }
}
    

