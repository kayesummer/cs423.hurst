using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStomp : MonoBehaviour
{
     private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
     {
          if(collision.gameObject.tag == "Weak Point")
          {
               Destroy(collision.gameObject);
          }
     }

}
