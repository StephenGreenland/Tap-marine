using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ACSkill : MonoBehaviour
{
    public PlayerStats playerRef;
    public MonsterManager monsterManagerRef;
    public MonsterBase currentMonster;
    public GameObject effect;

    
    private Color initColor;

    public float cooldownTime;
    public bool coolingDown = false;


    public void Awake()
    {
        initColor = this.GetComponent<Image>().color;
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
                effect.SetActive(true);
                currentMonster.GetComponent<Health>().Change(playerRef.damage * 3);
                yield return new WaitForSeconds(0.2f);
                effect.SetActive(false);

                yield return new WaitForSeconds(2f);

                effect.SetActive(true);
                currentMonster.GetComponent<Health>().Change(playerRef.damage * 3);
                yield return new WaitForSeconds(0.2f);
                effect.SetActive(false);

                yield return new WaitForSeconds(2f);
                effect.SetActive(true);
                currentMonster.GetComponent<Health>().Change(playerRef.damage * 3);
               yield return new WaitForSeconds(0.2f);

                effect.SetActive(false);
                coolingDown = true;
                cooldownTime = 5f;
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
