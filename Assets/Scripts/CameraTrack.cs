using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrack : MonoBehaviour
{
    //allows us to target a specific game object
    public Transform target;

    public Vector3 offset = new Vector3(0, 2, -10);

    //contols how snappy or slow the camera is in following the player
    public float smoothTime = 0.25f;

    Vector3 currentVelocity;

    // Update is called once per frame
    void LateUpdate()
    {
        //transforming bthe position of thecamera using the smoothDamp method. it needs the current position of the object, where it needs to go, its current velocity, and how long it takes to get to the new location
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref currentVelocity, smoothTime);
    }
}
