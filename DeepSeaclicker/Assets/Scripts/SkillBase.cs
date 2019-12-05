using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBase : MonoBehaviour
{
    public event Action OnActivate;


    protected virtual void ActivateEvent()
    {
        OnActivate?.Invoke();
    }
}
