using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseStuff : MonoBehaviour {
	public float forcePower = 500f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// called when mouse hovering over object
	//void OnMouseOver() {
		// rotate the object
		//transform.Rotate( new Vector3 (0, 90, 0) * Time.deltaTime);
	//}
    void OnMouseDown() {
		Vector3 forceDirection = Vector3.forward * forcePower;
		GetComponent<Rigidbody> ().AddForce (forceDirection);
      
}
}
