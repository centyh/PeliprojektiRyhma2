using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;

    //
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

 

    // Update is called once per frame
    void Update()
    {
        // Get inputs
        moveDirection = Input.GetAxisRaw("Horizontal"); // Scale of -1 -> 1.

       
        
        // Move
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

            
    }
}
