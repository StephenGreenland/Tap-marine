using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDisplay : MonoBehaviour

{
    public UnityEngine.UI.Text goldDisplay;
    public float GoldGain;
    public GameObject effectPos;
    public ParticleSystem goldParticle;
    public PlayerStats Ggold;
  


    // private bool leavechanger;

    // Start is called before the first frame update
    void Start()
    { 
        GoldGain = 1; //yay = GetComponent<MonsterManager>();
    //    yay.Onleave += GG;
    }

    // Update is called once per frame
    void Update()
    {
        goldDisplay.text = "Gold:" + Ggold.goldAmount;
        //GoldGain = Mathf.RoundToInt(MonsterManager.monsterLevel + Mathf.Round(GoldGain * 1.1f));
        GoldGain = Mathf.Round(MonsterManager.monsterLevel * 1.8f+(2f));


   
    }

    public void GG(MonsterBase m)
    {
       // Gold += GoldGain;
        //Instantiate(goldParticle, effectPos.transform.position, Quaternion.identity);
        
    }

}
