using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    
       public void OnCollision2D(Collision2D collision)
       {
        if(collision.gameObject.CompareTag("Player"))
        GameObject.Find("Enemy").SetActive(true);
       }
    
}
