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

    public  int monsterLevel;
    public event Action<MonsterBase> OnNew;
    public event Action<MonsterBase> Onleave;
    public event Action onmonsterlevelup;

    private float healthScaler;
   

    // Start is called before the first frame update
    void OnEnable()
    {
        SpawnMonster();
        healthScaler = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (monsterCount >= 10)
        {
            monsterCount = 0;
            monsterLevel++;
            onmonsterlevelup.Invoke();
            ScaleHealth();

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
            Debug.Log("boss1");
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
            currentMonster.GetComponent<Health>().amount +=  CalcHealth(healthScaler);
        }
    }

    float CalcHealth(float health)
    {
         return health * healthScaler;

    }

    public void ScaleHealth()
    {
        healthScaler = Mathf.Round(healthScaler * 1.6f);
        
    }

    
}
