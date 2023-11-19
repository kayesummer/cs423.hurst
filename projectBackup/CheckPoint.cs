using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
     private PlayerRespawn playerRespawn;
     
     
     // Start is called before the first frame update
    void Start()
    {
          playerRespawn = GameObject.Find("Player").GetComponent<PlayerRespawn>();   
    }

     // if player passes checkpoint, set new respawn point to the checkpoints location
     private void OnTriggerEnter2D(Collider2D collision)
     {
        if (collision.gameObject.name == "Player")
        {
               playerRespawn.respawnPoint = transform.position;
        }
     }


}
