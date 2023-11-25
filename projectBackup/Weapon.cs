using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
     public int damage;
     
     
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter2D(Collision2D collision)
     {
          if (collision.collider.gameObject.tag == "Enemy")
          {
               collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
          }
     }
}
