using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
     public int maxHealth;
     public int health;


     // Start is called before the first frame update
    void Start()
    {
          health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void TakeDamage(int amount)
     {
          health -= amount;
          if (health <= 0)
          {
               Destroy(gameObject);
          }
     }
}
