using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody2D playerRb;
     public float speed;
     public float input; //keeps track of x input (going left or right)

    // Update is called once per frame
    void Update()
    {
          input = Input.GetAxisRaw("Horizontal");
    }

     void FixedUpdate()
     {
          playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y);
     }
}
