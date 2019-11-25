using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CritLerp : MonoBehaviour
{
    public Color colorInitial;
    public Color color2;
    public SpriteRenderer spriteRef;
    public float timeBet;
    public float rotateSpeed;
    void Start()
    {
        spriteRef = GetComponent<SpriteRenderer>();
        //colorInitial = spriteRef.color;
    }

    // Update is called once per frame
    void Update()
    {
        spriteRef.transform.Rotate(0, 0, rotateSpeed*Time.deltaTime, Space.Self);
        spriteRef.color = Color.Lerp(colorInitial, color2, Mathf.PingPong(Time.time,timeBet));
    }
}
