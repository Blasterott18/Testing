using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tyler_script : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement (){
		/*
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, speed * Time.deltaTime, 0);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, -1 * speed * Time.deltaTime, 0);
		}
		*/
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-1 * speed * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (speed * Time.deltaTime, 0, 0);
		}

	}
}
