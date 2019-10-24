using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterbear : MonsterBase
{
    public Health health;

    private void OnEnable()
    {
        health.OnChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
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
