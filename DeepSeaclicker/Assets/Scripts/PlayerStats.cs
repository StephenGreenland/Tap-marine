using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float goldAmount;
    private float DamageLevel;
    public float damage;
    public float cost;
    public float goldMuiltiplayer;
    private float goldgain;

    public GameObject goldEffect;

 
    private float _newCost;
    public MonsterManager monsterManger;


    // Start is called before the first frame update
    void Start()
    {
        monsterManger.Onleave += MonsterMangerOnOnleave;
        goldMuiltiplayer = 1;
        
        goldAmount = 0;
        monsterManger.onmonsterlevelup += increasemulti;

    }

    private void MonsterMangerOnOnleave(MonsterBase obj)
    {
        goldAmount += CalcGold(obj.reward);
        Instantiate(goldEffect);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void upgradestats()
    {
        if (goldAmount >= cost)
        {
            
            goldAmount -= cost;
            damage = Mathf.Round(damage * 1.19f-(1));
            cost = Mathf.Round(cost * 1.20f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
           // Debug.Log(damage);
        }
   
    }

    private float CalcGold(float reward)
    {
        return  goldMuiltiplayer * reward;
    }
    void increasemulti()
    {

         goldMuiltiplayer = Mathf.Round(MonsterManager.monsterLevel * 2f + (3f));

    }
    private void OnDestroy()
    {
        monsterManger.onmonsterlevelup -= increasemulti;
        monsterManger.Onleave += MonsterMangerOnOnleave;
    }

}
