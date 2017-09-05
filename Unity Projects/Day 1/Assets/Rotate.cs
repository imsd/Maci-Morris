using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	//public means it will show up i the inspector

	//Vector3 is the variable type for 3D objects

	//myRotation is the variable type ive picked for 
	//roatiaon 

	public Vector3 myRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (myRotation * Time.deltaTime);
	}
}
