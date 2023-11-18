using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody2D playerRb;
     public float speed;
     public float input; // keeps track of x input (going left or right)
     public SpriteRenderer spriteRenderer;
     public float jumpForce;
     public LayerMask groundLayer; // allows labling things as ground
     private bool isGrounded; // if true, player can jump, else can't jump
     public Transform feetPosition;
     public float groundCheckCircle; // invisible circle on player feet that checks to see if the circle overlaps with the ground

    // Update is called once per frame
    void Update()
    {
          input = Input.GetAxisRaw("Horizontal");

          // flip the player depending on moving left/right
          if (input < 0)
          {
               spriteRenderer.flipX = true;  // flip
          }
          else if (input > 0)
          {
               spriteRenderer.flipX = false; // dont flip
          }

          // jumping

          // returns t/f whether or not player is on the ground, creates an invisible circle at players feet, 
          // make the circle the same size as groundCheckCircle, and checks if that circle overlaps the ground
          isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, groundLayer);
          if(isGrounded == true && Input.GetButton("Jump")) // is player on ground and jump button pressed?
          {
               playerRb.velocity = Vector2.up * jumpForce;  // jump 
          }
    }

     void FixedUpdate()
     {
          playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y);
     }
}
