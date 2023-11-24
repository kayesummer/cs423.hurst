using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     public int speed;
     public Transform playerTransform;
     public float chaseDistance;
     public bool isChasing;
     
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing == true)
        {
           transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        }

          if (Vector2.Distance(transform.position, playerTransform.position) <= chaseDistance)
          {
               isChasing = true;
          }
    }
}
