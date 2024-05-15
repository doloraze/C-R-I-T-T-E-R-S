using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public EnemyFollow enemy;

    // Update is called once per frame
    void Start()
    {
       // enemy = GetComponent<EnemyFollow>();
    }
    
       public void OnTriggerEnter2D(Collider2D collider)
       {
        if(collider.gameObject.CompareTag("Player"))
        Debug.Log("true");
            enemy.enabled = true;
       }
    
}
