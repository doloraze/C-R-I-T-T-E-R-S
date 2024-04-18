using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEff : MonoBehaviour
{
    private float length, startPos;
    public GameObject cam;
    public float parallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        //getting the x value of our starting position
        startPos = transform.position.x;
        //getting the length of the sprite
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //how far we have moved from start point
        float dist = (cam.transform.position.x * parallaxEffect);
        //move sprite based on Location of camera
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
    }
}
