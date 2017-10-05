using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

	// basic collision detection
	void OnCollisionEnter(Collision coll) {

		if (coll.gameObject.tag != "terrain") { 

			// what object am I colliding with?
			Debug.Log (coll.gameObject.name);

			// destroy the other game object
			//Destroy (coll.gameObject);

			// destroy THIS game object
			Destroy(this.gameObject);

			// rotate the collided object
			coll.transform.Rotate(new Vector3(45,0,0));

			// turn the collided object a different color (red)
			//coll.gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
	}
}