using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDisplay : MonoBehaviour

{
    public UnityEngine.UI.Text goldDisplay;
    public float Gold = 0f;
    public float GoldGain;
    public MonsterManager yay;
 
    // private bool leavechanger;

    // Start is called before the first frame update
    void Start()
    {
        GoldGain = 1; //yay = GetComponent<MonsterManager>();
        yay.Onleave += GG;
    }

    // Update is called once per frame
    void Update()
    {
        goldDisplay.text = "Gold:" + Gold;
      //  GoldGain = Mathf.RoundToInt(MonsterManager.monsterLevel + Mathf.Round(GoldGain * 1.1f));
        GoldGain = Mathf.Round(MonsterManager.monsterLevel * 1.01f+(GoldGain));
        //project manager add sprite animation here

        //if.getcomponent<goldskill>()buttonpressed&& button is enabled{
     //   GoldGain = Mathf.Round(80 * (GoldGain));
     //   countdowntimer 10f
     //if timer =0 gold return to normal 
     //set delay in other script

    }


    public void GG(MonsterBase m)
    {
       
      Gold += GoldGain;
                
    }
}
