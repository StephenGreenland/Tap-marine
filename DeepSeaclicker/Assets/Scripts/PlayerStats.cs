using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float goldAmount;
    private float DamageLevel;
    public float damage;
    public float cost;
    private int goldMuiltiplayer;
    

    private float _newCost;
    public MonsterManager monsterManger;
    
    
    // Start is called before the first frame update
    void Start()
    {
        monsterManger.Onleave += MonsterMangerOnOnleave; 
        
        DamageLevel = 1;
        damage = 1f;
    }

    private void MonsterMangerOnOnleave(MonsterBase obj)
    {
        goldAmount += CalcGold(obj.reward);
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
            damage = DamageLevel * 2.2f; 
            cost = Mathf.Round(cost * 1.3f);
            cost = Mathf.Round(cost * 1.3f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
        }
   
    }

    private int CalcGold(int reward)
    {
        return  goldMuiltiplayer * reward;
    }


}
