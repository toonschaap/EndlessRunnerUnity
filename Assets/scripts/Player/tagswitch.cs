using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagswitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("d")) {
			gameObject.tag = "attack";
		}
		else{
			gameObject.tag = "Player";
		}
	}
}
