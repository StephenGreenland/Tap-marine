using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 mousePos2D = new Vector2(mousePos.x, mousePos.z);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, mousePos2D);
            if (hit.collider != null)
            {
                
                hit.transform.position = new Vector2(Random.Range(-5,5),Random.Range(-5,5));
            }
        }


    }
}
