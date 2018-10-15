using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour {

    public float speed = 0;
    float now_speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.Space))
        {
            now_speed = speed;
        }
        transform.Rotate(new Vector3(0, 0, now_speed * Time.deltaTime));
        now_speed *= 0.98f;
        if (now_speed < 0.001f) now_speed = 0;
    }
}
