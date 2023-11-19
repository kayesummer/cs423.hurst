using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
     public int health;
     public int maxHealth;
     public TMP_Text healthPoints;
     private PlayerRespawn playerRespawn;

     private void Start ()
     {
          health = maxHealth;
          playerRespawn = GameObject.Find("Player").GetComponent<PlayerRespawn>();
     }

     void Update()
     {
          healthPoints.text = "HP: " + health + "/" + maxHealth;
     }
     
     public void TakeDamage(int amount)
     {
          health -= amount;
          if (health <= 0)
          {
               playerRespawn.RespawnNow();
               health = maxHealth / 2;
          }
     }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (collision.gameObject.name == "Enemy")
          {
               health -= 1;
               if(health <= 0)
               {
                    
               }
          }
     }
}
