using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Text textRef;
    public GameObject enemyRef;
    public float amountRef;
    // Update is called once per frame
    
    void Update()
    {
        
        if (enemyRef == null)
        {
            enemyRef = GameObject.FindGameObjectWithTag("Enemy");
        }
        if (enemyRef != null)
        {
            amountRef = enemyRef.GetComponent<Health>().amount;
            textRef.text = "Enemy Health: " + amountRef;

        }
    }
}
