using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public UnityEngine.UI.Text DamageDisplay;
    public float StaticDamage = 0;
    public float Damagedealt = 1f;
    public int Power;
    public GoldDisplay goldscript;
    public UnityEngine.UI.Text iteminfo;
    public float cost;
    public int counter = 0;
    private float newCost;
    public string itemName;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //  iteminfo.text = itemName + "\nCost" + cost + "\nPower" + Power;


    }
    public void attack() { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StaticDamage += Damagedealt;
            //   gameObject.GetComponent<Healthscript>().TakeDamage(Damagedealt); //enemy health
            DamageDisplay.text = "Damage:" + StaticDamage;    //interact with damage text display
                                                              //  gameObject.SetActive(true); for when i want to have the text reapear and disapear
        }

        if (Input.GetKeyUp(KeyCode.Space))    // reset damage
        {
            StaticDamage = 0;
            DamageDisplay.text = "Damage:" + StaticDamage;
            //   gameObject.SetActive(false);
        }
    }

    public void PurchasedUpgrades()
    {
        if (goldscript.Gold >= cost)
        {                         //need to make a function
            goldscript.Gold -= cost;
            counter += 1;
            goldscript.GoldGain += Power;
            cost = Mathf.Round(cost * 1.3f);
            newCost = Mathf.Pow(cost, newCost = cost);
        }

    }
}