using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAdd : MonoBehaviour
{
     public PlayerHealth playerHealth;


     // Start is called before the first frame update
     void Start()
     {
     }

     // if player passes checkpoint, set new respawn point to the checkpoints location
     private void OnTriggerEnter2D(Collider2D collision)
     {
          if (collision.gameObject.name == "Player")
          {
               if (playerHealth.health < playerHealth.maxHealth - 1)
               {
                    playerHealth.health += 2;
                    Destroy(gameObject);
               }
               else if (playerHealth.health == playerHealth.maxHealth - 1)
               {
                    playerHealth.health += 1;
                    Destroy(gameObject);
               }
               else
               {
                    Destroy(gameObject);
               }
          }
     }
}
