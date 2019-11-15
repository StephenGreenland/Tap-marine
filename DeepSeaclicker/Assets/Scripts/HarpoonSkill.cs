using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonSkill : MonoBehaviour
{
    bool skillActive = false;
    public float HarpoonDamage;
    public float cooldownTime;
    public GameObject clickManagerRef;

    public void HarpoonActivated()
    {
        if (skillActive) return;
        clickManagerRef.GetComponent<ClickedManager>().damage -= HarpoonDamage;
    }
    public void Update()
    {
        Debug.Log(clickManagerRef.GetComponent <ClickedManager> ().damage);
    }
}
