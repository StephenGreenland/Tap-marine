using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerStats : MonoBehaviour
{
    public float goldAmount;
    private float DamageLevel;
    public float damage;
    public float cost;
    public float goldMuiltiplayer;
    private float goldgain;
    
    //string paths = Application.persistentDataPath + ("/PlayerStats.txt");
    private string paths;
    
    string storeText;
    private string[] savefile;

    public GameObject goldEffect;

 
    private float _newCost;
    public MonsterManager monsterManger;


    // Start is called before the first frame update
    void Start()
    {
        
        
        if(Application.isEditor)
        {
            paths = Application.persistentDataPath  + ("/SaveFile.txt");
        }
        else
        {
            paths = Application.persistentDataPath + ("/SaveFile.txt");
        }
        monsterManger.Onleave += MonsterMangerOnOnleave;
        goldMuiltiplayer = 1;
        goldAmount = 0;
        monsterManger.onmonsterlevelup += increasemulti;
        
        LoadStats();

    }

    private void MonsterMangerOnOnleave(MonsterBase obj)
    {
        goldAmount += CalcGold(obj.reward);
        Instantiate(goldEffect);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void upgradestats()
    {
        if (goldAmount >= cost)
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Ui/Upgrade", gameObject);
            goldAmount -= cost;
            damage = Mathf.Round(damage * 1.19f-(1));
            cost = Mathf.Round(cost * 1.16f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
           // Debug.Log(damage);
        }
        else
        {
            FMODUnity.RuntimeManager.PlayOneShotAttached("event:/Ui/NoMoney", gameObject);
        }
    }

    private float CalcGold(float reward)
    {
        return  goldMuiltiplayer * reward;
    }
    void increasemulti()
    {

         goldMuiltiplayer = Mathf.Round(monsterManger.monsterLevel * 2f + (3f));

    }
    private void OnDestroy()
    {
        monsterManger.onmonsterlevelup -= increasemulti;
        monsterManger.Onleave -= MonsterMangerOnOnleave;
    }

    public void SaveStats()
    {
        
        StreamWriter sw = new StreamWriter(paths);
        storeText = cost + ","+ goldAmount + "," + damage;
        
        sw.WriteLine(storeText);
        sw.Close();
    }
    private void LoadStats()
    {
        StreamReader reader = new StreamReader(paths);
        string loadScore = reader.ReadLine();
        savefile = loadScore.Split(',');
        cost = float.Parse(savefile[0]);
        goldAmount = float.Parse(savefile[1]);
        damage = float.Parse(savefile[2]);

    }
}
