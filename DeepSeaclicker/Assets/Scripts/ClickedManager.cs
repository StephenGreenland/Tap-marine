using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedManager : MonoBehaviour
{
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10f));
           

            RaycastHit2D hit = Physics2D.Raycast(mousePosWorld, Vector2.zero);
           
             if (hit.collider != null)
              {
                  if (hit.collider.gameObject.GetComponent<Crit>())
                  {
                      hit.collider.gameObject.GetComponent<Crit>().monster.GetComponent<Health>().Change(damage * hit.collider.gameObject.GetComponent<Crit>().critMultiplier);                          
                          
                      hit.collider.gameObject.GetComponent<Crit>().GotHit(hit.collider.gameObject.GetComponent<Crit>().ChoosePos());
                  }
                  else
                  {
                      hit.transform.gameObject.GetComponent<Health>().Change(damage);
                  }
              } 
        }
    }
}


