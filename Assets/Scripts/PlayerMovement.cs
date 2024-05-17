using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;

    public Animator animator;
    float horizontalMovement = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;
        Vector2 moveVector = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));

        rb.velocity = new Vector2(horizontalInput, verticalInput) * moveSpeed;

        if(horizontalInput < 0){
            transform.localScale = new Vector3(-0.14f, 0.14f, 1);
        } else if(horizontalInput > 0){
            transform.localScale = new Vector3(0.14f, 0.14f, 1);
        }
    }
}
