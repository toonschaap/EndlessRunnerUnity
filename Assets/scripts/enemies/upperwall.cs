using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upperwall : MonoBehaviour {
	  List<int> enemies = new List<int>();
   
    public GameObject wall;
    GameObject wallclone;
    public float Timer = 2;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            wallclone = Instantiate(wall, new Vector3(5.0f,3.0f,0), transform.rotation) as GameObject;
            Timer = Random.Range(2.0f, 3.0f);
        }
    }
}