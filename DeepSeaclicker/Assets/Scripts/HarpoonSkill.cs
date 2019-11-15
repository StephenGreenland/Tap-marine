using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonSkill : MonoBehaviour
{
    bool clickAfterSkill = false;
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
            clickManagerRef.GetComponent<ClickedManager>().damage -= HarpoonDamage;
        }
    }
    public void Update()
    {
        //Debug.Log(clickManagerRef.GetComponent <ClickedManager> ().damage);
    }
}
