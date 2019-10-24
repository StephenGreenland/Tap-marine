using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MonsterManager : MonoBehaviour
{
    public GameObject[] monsters;
    private GameObject currentMonster;
    private int monsterCount;
    
    
    // Start is called before the first frame update
    void OnEnable()
    {
        SpawnMonster();
    }

    // Update is called once per frame
    void Update()
    {
        if (monsterCount > 10)
        {
            Debug.Log("Do The Thing");
        }
    }

    private int GetMonster()
    {
         return Random.Range(0, monsters.Length);
    }

    private void SpawnMonster()
    {
        if(currentMonster != null)currentMonster.GetComponent<MonsterBase>().Leave -= SpawnMonster;
        currentMonster = Instantiate(monsters[GetMonster()], new Vector3(0,4,9),Quaternion.identity);
        currentMonster.GetComponent<MonsterBase>().Leave += SpawnMonster;
        monsterCount++;
    }
}
