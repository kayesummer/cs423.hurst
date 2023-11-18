using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) 
          {
               StartCoroutine(FallTimer());
          }
    }

     IEnumerator FallTimer()
     {
          GetComponent<BoxCollider2D>().enabled = false; // turns off the capsule collider briefly
          yield return new WaitForSeconds(0.25f); // wait 0.15f seconds to reenable collider
          GetComponent<BoxCollider2D>().enabled = true; // reenables the capsule collider 
     }
}
