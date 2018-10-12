using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidecollider : MonoBehaviour {
	public Collider box;
	public Collider slide;
	public Collider attack;
	
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown("s"))
         {
 		box.enabled = false;
		 slide.enabled = true;
		 }
		 else if(Input.GetKeyDown("d")){
			 box.enabled = false;
		 attack.enabled = true;
		 }
	}
}

