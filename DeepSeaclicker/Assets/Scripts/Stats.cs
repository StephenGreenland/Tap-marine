using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class Stats : MonoBehaviour
{

    public int currentScore;
    public int multiplier;
    public int notesInRow;

    public int[] filescore;

    public string[] score;

    string paths = Application.persistentDataPath + ("/HighScores.txt");

    public int currentLevel; //go into each level and set this
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
        multiplier = 1;
        Read();

    }

    // Update is called once per frame
    void Update()
    {


    }
    // compares the saved score agianst the currentscore
    public void GetHighScore()
    {
        Read();

        if (currentScore > filescore[currentLevel])
        {
            Debug.Log("Write new high score");
            NewHeighScore();

            filescore[currentLevel] = currentScore;
        }



    }
    // saves the current score into the text file
    public void NewHeighScore()
    {
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
    }

    void Read()
    {
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
    }

    //Calculate score
    public void CalScore()
    {
        currentScore = currentScore + (1 * multiplier);
    }

    //Multiplier code function
    public void Notes()
    {
        notesInRow++;
        if (notesInRow % 4 == 0) //After every 4 notes are collected
        {

            if (multiplier < 4) //Max Multiplier 4
            {
                multiplier++;
            }

        }

    }
    public void HitOb()
    {
        multiplier = 1;
        notesInRow = 0;
    }
    public void Reset()
    {
        for (int i = 0; i <= 3; i++)
        {
            filescore[i] = 0;
            NewHeighScore();
        }

    }

}
