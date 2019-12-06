using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skills : MonoBehaviour
{
    public bool skillon = false;
    public float timeLeft = 15f; // will change to 20 after testing 
    public float recoverytime = 25f;
    public float multiplyer = 1f;
    bool isSkillonActive = false;
    private GoldDisplay goldscript;
    public PlayerStats yeet;
    public UnityEngine.UI.Text iteminfo;
    public UnityEngine.UI.Text skill1damage;
    public UnityEngine.UI.Text skill1damage2;
    public string itemName;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        iteminfo.text = itemName + "\nCost: " + yeet.cost + "\nDamage: " + (yeet.damage * -1);
        skill1damage.text = "\nDamage: " + yeet.damage * -5 ;
        skill1damage2.text = "\nDamage: " + yeet.damage * -3;
        if (Input.GetKey(KeyCode.Space))
        {
            SetSkillonActive();
        }
       
    }
   

    public void SetSkillonActive()
    {
        
        if (isSkillonActive) return;
        skillon = true;
        multiplyer = 10f;
        if (multiplyer == 10)
        {
            yeet.goldMuiltiplayer = Mathf.Round(goldscript.GoldGain) * multiplyer;
        }
        StartCoroutine(SkillonTimeOut());

    }

    private IEnumerator SkillonTimeOut()
    {
        isSkillonActive = true;
        yield return new WaitForSeconds(timeLeft);
        multiplyer = 1f;
        if (isSkillonActive == true){
            goldscript.GoldGain = Mathf.Round(goldscript.GoldGain) / 10f;
        }
        isSkillonActive = false;
        skillon = false;
        
    }
    //set a cooldown timer make it so you can only activate the skill once

}

