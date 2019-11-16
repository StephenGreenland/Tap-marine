using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OW_WhirlPool: MonoBehaviour
{
    public string sceneToLoad;
    public GameObject Boss1;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    
    }
}
