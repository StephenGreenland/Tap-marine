using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUI : MonoBehaviour
{
    //public bool skillon = false;
    //public float timeLeft = 15f; // will change to 20 after testing 
    //public float recoverytime = 25f;
    //public float multiplyer = 1f;
    //bool isSkillonActive = false;
    //private GoldDisplay goldscript;
    public PlayerStats yeet;
    public Text upgradeText;
    public Text harpoon;
    public Text autoCannon;
    public Text currentDMG;
    // Update is called once per frame
    void Update()
    {
        currentDMG.text = "Current DMG: " + (yeet.damage *-1);
        upgradeText.text = "Cost: " + yeet.cost + "\nDMG: " + (Mathf.Round(yeet.damage * -1.19f));
        harpoon.text = "DMG: " + yeet.damage * -5;
        autoCannon.text = "DMG: " + yeet.damage * -4 + " x 3";
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    SetSkillonActive();
        //}

    }
}
   

//    public void SetSkillonActive()
//    {
        
//        if (isSkillonActive) return;
//        skillon = true;
//        multiplyer = 10f;
//        if (multiplyer == 10)
//        {
//            yeet.goldMuiltiplayer = Mathf.Round(goldscript.GoldGain) * multiplyer;
//        }
//        StartCoroutine(SkillonTimeOut());

//    }

//    private IEnumerator SkillonTimeOut()
//    {
//        isSkillonActive = true;
//        yield return new WaitForSeconds(timeLeft);
//        multiplyer = 1f;
//        if (isSkillonActive == true){
//            goldscript.GoldGain = Mathf.Round(goldscript.GoldGain) / 10f;
//        }
//        isSkillonActive = false;
//        skillon = false;
        
//    }
//    //set a cooldown timer make it so you can only activate the skill once

//}

