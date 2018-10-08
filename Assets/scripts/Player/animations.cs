using UnityEngine;
using System.Collections;

public class animations : MonoBehaviour {
	
	public Animator anim;
	public Rigidbody rbody;


	private float inputH;
	private float inputV;
	private bool run;

    // Use this for initialization
    private void Start () 
	{
		anim = GetComponent<Animator>();
		rbody = GetComponent<Rigidbody>();
		run = false;
	}

    // Update is called once per frame
    private void Update ()
	{
		

		if (Input.GetKey ("space")) {
			anim.Play ("jump");

			anim.SetBool ("Jumpbool", true);
		}
		else if (Input.GetKey ("w")) {
			anim.Play ("shoot");
		}
		else if (Input.GetKey ("s")) {
			anim.Play ("slide");
		}
		
		else {
			anim.Play ("run");
	}
	
 }
 private void OnCollisionEnter(Collision collision){
 	if (collision.gameObject.tag == "Enemy"){
			anim.Play ("death");
		}
 }
 }
	
