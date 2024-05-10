using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
       private void OnCollisonEnter2D(Collision2D collision)
      {
        if(collision.gameObject.CompareTag("Player"));
        
        
      }
    
}
