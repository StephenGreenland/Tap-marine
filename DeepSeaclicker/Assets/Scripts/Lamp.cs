using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lamp : MonoBehaviour
{
    public Color colorInitial;
    public Color color2;
    public Image spriteRef;
    public float timeBet;
    void Start()
    {
        spriteRef = GetComponent<Image>();
        //colorInitial = spriteRef.color;
    }

    // Update is called once per frame
    void Update()
    {
        spriteRef.color = Color.Lerp(colorInitial, color2, Mathf.PingPong(Time.time,timeBet));
    }
}
