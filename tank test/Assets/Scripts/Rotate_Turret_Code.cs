using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Turret_Code : MonoBehaviour {

    public float rotate = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("q"))
        {
            transform.Rotate(0, Time.deltaTime * rotate, 0);
        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(0, Time.deltaTime * -rotate, 0);
        }
    }
}
