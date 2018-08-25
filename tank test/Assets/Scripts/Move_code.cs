using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_code : MonoBehaviour {

    public float speed = 5;
    public float rotate = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, Time.deltaTime * rotate,0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, Time.deltaTime * -rotate, 0);
        }
    }
}
