using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          //Rigidbody body = GetComponent<RigidBody>();
          //if (body != null)
          //{
               //body.freezeRotation = true;
          //}
     }
 
     public enum RotationAxes
     {
          MouseXAndY = 0,
          MouseX = 1,
          MouseY = 2
     }
     public RotationAxes axes = RotationAxes.MouseXAndY;
     public float sensitivityHor = 9.0f;

     public float sensitivityVert = 9.0f;


     public float minimumVert = -45.0f;
     public float maximumVert = 45.0f;

     private float verticalRot = 0;

     void Update()
     {
          if (axes == RotationAxes.MouseX)
          {
               transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
          }
          else if (axes == RotationAxes.MouseY)
          {
               // vertical rotation here  
               verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
               verticalRot = Mathf.Clamp(verticalRot, minimumVert, maximumVert);

               float horizontalRot = transform.localEulerAngles.y;

               transform.localEulerAngles = new Vector3(verticalRot, horizontalRot, 0);

          }
          else
          {
               // both horizontal and vertical rotation here 
               verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
               verticalRot = Mathf.Clamp(verticalRot, minimumVert, maximumVert);

               float delta = Input.GetAxis("Mouse X") * sensitivityHor;
               float horizontalRot = transform.localEulerAngles.y + delta;

               transform.localEulerAngles = new Vector3(verticalRot, horizontalRot, 0);

          }
     }
}

