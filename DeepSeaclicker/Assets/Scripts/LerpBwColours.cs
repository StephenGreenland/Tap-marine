using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBwColours : MonoBehaviour
{
    public Color colorInitial;
    public Color color2;
    public SpriteRenderer spriteRef;
    public float timeBet;
    void Start()
    {
        spriteRef = GetComponent<SpriteRenderer>();
        //colorInitial = spriteRef.color;
    }

    // Update is called once per frame
    void Update()
    {
        spriteRef.color = Color.Lerp(colorInitial, color2, Mathf.PingPong(Time.time,timeBet));
    }
}
