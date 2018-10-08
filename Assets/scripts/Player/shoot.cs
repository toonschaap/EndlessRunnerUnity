 using UnityEngine;
 using System.Collections;
 
 public class shoot : MonoBehaviour {
     public GameObject projectile;
	 public float moveSpeed;
     private float maxSpeed = 1000f;
     private Vector3 input;
 
     void Start () {
         
     }
 
     void Update () {
           if (Input.GetKeyDown(KeyCode.W))
         {
             GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
             bullet.GetComponent<Rigidbody>().AddForce(transform.right * 100);
         }
     }
 }