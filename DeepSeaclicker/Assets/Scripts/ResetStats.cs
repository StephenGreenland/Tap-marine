using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ResetStats : MonoBehaviour
{

    public string paths;
    string storeText;
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
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Reset Stats")]
    public void Reset()
    {
        StreamWriter sw = new StreamWriter(paths);
        storeText = 10 + ","+ 0 + "," + -2;
        
        sw.WriteLine(storeText);
        sw.Close();
    }
}
