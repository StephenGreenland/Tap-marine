using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    
    public UnityEngine.UI.Text iteminfo;
    public float cost;
    public int counter = 0;
    public int clickpower;
    public string itemName;
    private float _newCost;

    public GoldDisplay goldscript;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        iteminfo.text = itemName + "\nCost: " + cost + "\nPower: " + clickpower;

    }

    public void PurchasedUpgrades()
    {
        if (goldscript.Gold >= cost)
        {                         //need to make a function
           
            goldscript.Gold -= cost;
            counter += 1;
            
            cost = Mathf.Round(cost * 1.3f);
            _newCost = Mathf.Pow(cost, _newCost = cost);

         
        }

    }
}


















/*public void PurchasedUpgrades()
{
        if (goldscript.Gold >= cost)
        {                         //need to make a function
            goldscript.Gold -= cost;
            counter += 1;
            goldscript.GoldGain += clickpower;
            cost = Mathf.RoundToInt((float) cost * 1.3f);
            _newCost = Mathf.Pow(cost, _newCost = cost);         
         
        }

    }*/