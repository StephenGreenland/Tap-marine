using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthscript : MonoBehaviour
{
    public bool dead;
    public float MaxHealth=10f;
    public float CurrentHealth = 0f;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {
        if (CurrentHealth<= 0){
            CurrentHealth = 0;
            dead = true;
            //destroy and load next enemy
        }
        if (!dead)
        {
            return;
        }

        CurrentHealth -= amount;
    }
}
