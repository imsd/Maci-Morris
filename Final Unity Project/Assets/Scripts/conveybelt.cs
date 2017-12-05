using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveybelt : MonoBehaviour {
	void Start(){

	}

	// Update is called once per frame
	void Update () {
    
	}
	void OnCollisionEnter(Collision c) {
		c.transform.parent = transform;
	}
}
