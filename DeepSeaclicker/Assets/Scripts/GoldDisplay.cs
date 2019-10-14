using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDisplay : MonoBehaviour
{
    public UnityEngine.UI.Text goldDisplay;
    public float Gold = 0f;
    public float GoldGain = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Gold +=GoldGain;
            goldDisplay.text = "Gold:" + Gold;
        }
    }

}
