using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public UnityEngine.UI.Text DamageDisplay;
    public float StaticDamage=0;
    public float Damagedealt = 1f;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StaticDamage += Damagedealt;
            //   gameObject.GetComponent<Healthscript>().TakeDamage(Damagedealt); //enemy health
            DamageDisplay.text = "Damage:" + StaticDamage;    //interact with damage text display
                        
        }
        if (Input.GetKeyUp(KeyCode.Space))    // reset damage
        {
            StaticDamage = 0;
            DamageDisplay.text = "Damage:" + StaticDamage;
        }
    }
}