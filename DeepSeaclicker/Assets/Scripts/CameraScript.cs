using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class CameraScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    Vector2 mousePosWorld2D;

    // Update is called once per frame
    void Update()
    {
//        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosWorld = new Vector3(0f,0f,0f);
            mousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));

            RaycastHit2D hit = Physics2D.Raycast(mousePosWorld, Vector2.zero);
            if (hit.collider != null)
            {
                
                hit.transform.position = new Vector2(Random.Range(-5,5),Random.Range(-5,5));
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0,1,0,0.25f);
        Gizmos.DrawSphere(mousePosWorld2D, 5f);
    }
}
