using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFish : MonoBehaviour
{
    public Health health;
    
    private void OnEnable()
    {
        health.OnChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        Debug.Log("DIE!");
        health.OnChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float amount)
    {
        if (amount < 0)
        {
            Destroy(gameObject);
        }
    }
}
