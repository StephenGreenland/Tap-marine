using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class Stats : MonoBehaviour
{

    string paths = Application.persistentDataPath + ("/PlayerStats.txt");
    string storeText;

    public delegate void ReadComplete();
    public event ReadComplete OnRead;

    // Start is called before the first frame update
    void Awake()
    {
        if (!File.Exists(paths))
        {
            File.WriteAllText(paths, "0,0,0,0");
        }
        
        Read();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    // compares the saved score against the currentScore
    public void GetHighScore()
    {
        Read();
        
            Debug.Log("Write new high score");
            NewHeighScore();
            
    }
    // saves the current score into the text file
    public void NewHeighScore()
    {
        /*
        StreamWriter sw = new StreamWriter(paths);
        storeText = "";

        for (int i = 0; i <= 3; i++)
        {
            Debug.Log(i.ToString());
            if (i == currentLevel)
            {
                filescore[i] = currentScore;

            }
            if (i == 3)
            {
                storeText += (filescore[i].ToString());

            }
            else
            {
                storeText += (filescore[i].ToString() + (','));
            }

        }
        
        sw.WriteLine(storeText);

        sw.Close();
        */
    }

    void Read()
    {
        /*
        String path = paths;
        StreamReader reader = new StreamReader(path);
        string loadScore = reader.ReadLine();

        score = loadScore.Split(',');
        Debug.Log(filescore.Length);

        for (int i = 0; i < score.Length; i++)
        {
            filescore[i] = int.Parse(score[i]);


        }
        
        reader.Close();

        OnRead?.Invoke();
        */
    }

    //Calculate score
    
    public void Reset()
    {
        NewHeighScore();
    }

}
