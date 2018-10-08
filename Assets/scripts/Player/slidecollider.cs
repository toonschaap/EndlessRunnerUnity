using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidecollider : MonoBehaviour {
	public Collider box;
	public Collider slide;
	
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown("s"))
         {
 		box.enabled = false;
		 slide.enabled = true;
	}
}
}
