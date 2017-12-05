using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticktBelt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision c) {
	c.transform.parent = transform;
	}
}
