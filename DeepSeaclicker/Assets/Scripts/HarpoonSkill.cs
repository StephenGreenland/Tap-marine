using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonSkill : MonoBehaviour
{
    //bool clickAfterSkill = false;
    bool skillActive = false;
    public float HarpoonDamage;
    public float cooldownTime;
    public GameObject clickManagerRef;

    public void HarpoonActivated()
    {

        if (skillActive) return;
        skillActive = true;
        if (skillActive)
        {
            //adding 5 times the amount of base damage to base damage. This is so that Harpoon Damage scales with base damage
            clickManagerRef.GetComponent<ClickedManager>().damage += 5* (clickManagerRef.GetComponent<ClickedManager>().damage);

        }
    }
    public void Update()
    {
        Debug.Log(clickManagerRef.GetComponent <ClickedManager> ().damage);
    }
}
