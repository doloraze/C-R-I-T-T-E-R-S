using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaypoint : MonoBehaviour
{
    public float PlayerSpeed = 5.0f;
    public GameObject[] wayPoints;
    private int currentWayPoint;

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * PlayerSpeed);
    }
}
