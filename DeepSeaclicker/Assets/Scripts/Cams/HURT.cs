using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HURT : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject.FindObjectOfType<Health>().Change(-1);
        }
    }
}
