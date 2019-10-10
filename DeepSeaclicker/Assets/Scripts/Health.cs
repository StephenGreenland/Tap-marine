using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    
    
    public event Action<float> OnChanged;

    private float health;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change(float incomeingAmount)
    {
        health += incomeingAmount;

        if (OnChanged != null)
        {
            OnChanged(incomeingAmount);
        }
    }
    
}
