using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public Transform enemyTransform;

    private void Start()
    {
        StartBattle();
    }

    private void StartBattle()
    {
        Debug.Log("StartBattle");
        enemyTransform.GetComponent< EnemySpawn >().Spawn();
    }
}
