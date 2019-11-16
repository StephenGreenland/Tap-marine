using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class MonsterManager : MonoBehaviour
{
   
    public MonsterBase[] monsters;
    public MonsterBase currentMonster;
    private int monsterCount;
    public GameObject boss1;

    public static int monsterLevel;
    public event Action<MonsterBase> OnNew;
    public event Action<MonsterBase> Onleave;
    
    
    // Start is called before the first frame update
    void OnEnable()
    {
        SpawnMonster();
    }

    // Update is called once per frame
    void Update()
    {
        if (monsterCount >= 10)
        {
            monsterCount = 0;
            monsterLevel++;

        }
    }

    private int GetMonster()
    {
         return Random.Range(0, monsters.Length);
    }

    private void SpawnMonster()
    {
        // cleaning up after myself
        if (monsterLevel == 10)
        {
            currentMonster.GetComponent<MonsterBase>().Leave -= SpawnMonster;
            boss1.SetActive(true);

        }
        else if (currentMonster != null && monsterLevel != 10)
        {
            currentMonster.GetComponent<MonsterBase>().Leave -= SpawnMonster;

        }
        if (monsterLevel != 10)
        {
            Onleave?.Invoke(currentMonster);

            //making the monster
            currentMonster = Instantiate(monsters[GetMonster()], new Vector3(0, 4, 9), Quaternion.identity);
            currentMonster.GetComponent<MonsterBase>().Leave += SpawnMonster;
            OnNew?.Invoke(currentMonster);
            monsterCount++;
        }
    }
}
