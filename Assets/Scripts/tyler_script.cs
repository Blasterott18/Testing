using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tyler_script : MonoBehaviour {

	public float jumpSpeed;
	public float speed;
	public Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
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
		if (Input.GetKeyDown (KeyCode.Space)) {
			rigid.AddForce (transform.up * jumpSpeed, ForceMode2D.Impulse);
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-1 * speed * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (speed * Time.deltaTime, 0, 0);
		}

	}
}
