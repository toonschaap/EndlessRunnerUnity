 using UnityEngine;
 using System.Collections;
 
 public class enemydead : MonoBehaviour 
 {
     //Check for collisions, remove after X seconds if no collision
     void Update () 
    {

	}
 
     void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag == "bullet") 
         {
             Destroy (gameObject);
             Debug.Log("Deleted enemy");
         }
     }
 }