using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour {

    public float speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
        }	

	}
}
