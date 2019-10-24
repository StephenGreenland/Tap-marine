using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action<float> OnChanged;
    public float amount;

    public void Change(float incomingAmount)
    {
        amount += incomingAmount;

        if (OnChanged != null)
        {
            OnChanged(incomingAmount);
        }
    }
    
}
