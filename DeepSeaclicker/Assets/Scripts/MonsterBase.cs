using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBase : MonoBehaviour
{
    public event Action Leave;
    
    protected virtual void OnLeave()
    {
        Leave?.Invoke();
    }
    
    public virtual int CalcGold(int reward)
    {
        //return reward * monsterLevel;
        return reward;
    }
}
