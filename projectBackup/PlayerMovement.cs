using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody2D playerRb;
     public float speed;
     public float input; //keeps track of x input (going left or right)
     public SpriteRenderer spriteRenderer;

    // Update is called once per frame
    void Update()
    {
          input = Input.GetAxisRaw("Horizontal");
          if (input < 0)
          {
               spriteRenderer.flipX = true;
          }
          else if (input > 0)
          {
               spriteRenderer.flipX = false;
          }
    }

     void FixedUpdate()
     {
          playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y);
     }
}
