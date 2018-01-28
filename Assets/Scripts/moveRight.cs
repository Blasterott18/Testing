using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		
	}

	void Movement (){
		transform.Translate (10 * Time.deltaTime, 0, 0);
	}
}
