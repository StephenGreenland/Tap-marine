using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buisnessblob : MonsterBase
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

        if (health.amount <= 0)
        {
            OnLeave();
            Destroy(gameObject);

        }
    }
}
