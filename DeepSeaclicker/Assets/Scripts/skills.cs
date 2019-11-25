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
    public GoldDisplay goldscript;
    public PlayerStats yeet;
    public UnityEngine.UI.Text iteminfo;
    public string itemName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        iteminfo.text = itemName + "\nCost: " + yeet.cost + "\nPower: " + (yeet.damage * -1);

        if (Input.GetKey(KeyCode.Space))
        {
            SetSkillonActive();
        }
       
    }
    public void GoldSkill()
    {
        //if (skillon == true & )
        //{
          //  isSkillonActive = true;
            
            //this.gameObject.SetActive(false); // change to button
            
            
            //timeLeft -= Time.deltaTime;
            //if (timeLeft < 0)
            //{
            //    skillon = false;
            //}
            //if (skillon == false)
            //{
            //    recoverytime -= Time.deltaTime;
            //    if (recoverytime < 0)
            //    {
            //        skillon = true;
            //    }

           // }
       // }

        goldscript.GoldGain = Mathf.Round(goldscript.GoldGain) * multiplyer;
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

