using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDegrees : MonoBehaviour {
	
	//public float yRotation = 90.0f;
	//public float xRotation = 90.0f;
	//public float zRotation = 90.0f;
//	public float RotationSpeed = 30.0f;
	private bool rotating1 = true;
	private bool rotating2 = true;
	private bool rotating3 = true;
	private bool rotating4 = true;
	private bool rotating5 = true;
	private bool rotating6 = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
//		transform.Rotate (Vector3.up, * (RotationSpeed * Time.deltaTime));
//		if (Input.GetKeyDown ("space")) {
//		Application.LoadLevel ("Cube");
//		}
			if (rotating1) {
			Vector3 to = new Vector3 (90, 0, 0);
			if (Vector3.Distance (transform.eulerAngles, to) > 0.01f) {
				transform.eulerAngles = Vector3.Lerp (transform.rotation.eulerAngles, to, Time.deltaTime);
			} else {
				transform.eulerAngles = to;
				rotating1 = false;
			}
		} else if (rotating2) {
			Vector3 to2 = new Vector3 (0, 90, 0);
			if (Vector3.Distance (transform.eulerAngles, to2) > 0.01f) {
				transform.eulerAngles = Vector3.Lerp (transform.rotation.eulerAngles, to2, Time.deltaTime);
			} else {
				transform.eulerAngles = to2;
				rotating2 = false;
			}
			
		} else if (rotating3) {
			Vector3 to3 = new Vector3 (0, 0, 360);
			if (Vector3.Distance (transform.eulerAngles, to3) > 0.01f) {
				transform.eulerAngles = Vector3.Lerp (transform.rotation.eulerAngles, to3, Time.deltaTime);
			} else {
				transform.eulerAngles = to3;
				rotating3 = false;
			}
		}
		else if (rotating4) {
			Vector3 to4 = new Vector3 (0, 180, 0);
			if (Vector3.Distance (transform.eulerAngles, to4) > 0.01f) {
				transform.eulerAngles = Vector3.Lerp (transform.rotation.eulerAngles, to4, Time.deltaTime);
			} else {
				transform.eulerAngles = to4;
				rotating4 = false;
			}
		}
		else if (rotating5) {
			Vector3 to5 = new Vector3 (0, 270, 0);
			if (Vector3.Distance (transform.eulerAngles, to5) > 0.01f) {
				transform.eulerAngles = Vector3.Lerp (transform.rotation.eulerAngles, to5, Time.deltaTime);
			} else {
				transform.eulerAngles = to5;
				rotating5 = false;
			}
		}
		else if (rotating6) {
			Vector3 to6 = new Vector3 (90, 180, 0);
			if (Vector3.Distance (transform.eulerAngles, to6) > 0.01f) {
				transform.eulerAngles = Vector3.Lerp (transform.rotation.eulerAngles, to6, Time.deltaTime);
			} else {
				transform.eulerAngles = to6;
				rotating6 = false;
			}
		}

			
}
}