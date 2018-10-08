using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
	bool pausegame = false;
	
	void Update () {
		if (Input.GetKeyDown("escape")){
			pausegame = !pausegame;
			Change();
		}
	}
	
	void Change(){
		if(pausegame)
		Time.timeScale = 0;

		if(!pausegame){
			Time.timeScale = 1;
		}
	}
}
