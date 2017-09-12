using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iteration : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
		//for loop
		//has four components
		//ist
		//2nd
		//
		for (int i = 0; i < 10; i++) {
			Vector3 myVec = new Vector3 (i - 5, 2, 0);

			Instantiate (go, myVec, Quaternion.identity);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
