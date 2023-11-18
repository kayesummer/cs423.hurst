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
     public float jumpTime = 0.35f; // jump timer
     public float jumpTimeCounter;
     private bool isJumping;

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
          if(isGrounded == true && Input.GetButtonDown("Jump")) // is player on ground and jump button pressed?
          {
               isJumping = true;
               jumpTimeCounter = jumpTime;
               playerRb.velocity = Vector2.up * jumpForce;  // jump 
          }

          // allows a higher jump when holding space bar
          if (Input.GetButton("Jump") && isJumping == true)  // in a jump
          {
               if (jumpTimeCounter > 0)
               {
                    playerRb.velocity = Vector2.up * jumpForce;  // jump higher
                    jumpTimeCounter -= Time.deltaTime;
               }
               else // once timer runs out, player is not jumping anymore
               {
                    isJumping = false;
               }
          }

          // jump button is not pressed, so player is not jumping
          if (Input.GetButtonUp("Jump"))
          {
               isJumping = false;
          }
    }

     void FixedUpdate()
     {
          playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y);
     }
}
