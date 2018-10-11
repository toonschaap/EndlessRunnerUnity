 using UnityEngine;
 using System.Collections;
 
 public class bulletwallcollision : MonoBehaviour 
 {
	 GameObject bullet;
     //Check for collisions, remove after X seconds if no collision
     void Update () 
    {

	}
 
     void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag == "Enemy") 
         {
             Destroy (gameObject);
             Debug.Log("Deleted bullet");
         }
		 else if (collision.gameObject.tag == "wall") 
         {
             Destroy (gameObject);
             Debug.Log("Deleted bullet");
         }
     }
 }
