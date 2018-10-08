using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randowspawn : MonoBehaviour {

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
            wallclone = Instantiate(wall, new Vector3(3.0f,0.0f,0), transform.rotation) as GameObject;
            Timer = Random.Range(2.0f, 3.0f);
        }
    }
}