using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	//added game object to inspectore
	//that can be accessed in script
	public GameObject go;
	// start spawing after x seconds
	public float StartAfter = 1f;
	// how often to spawn objects
	public float SpawnFrequency = 0.5f; 

	
	// Use this for initialization
	void Start () {
		// repeat a funtion
		// 1: what you want to repeat
		// 2: after how many seconds do you want to start doing it
		// 3: repeat every X seconds

		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing () {

	    // first, move the spawner
		transform.position = new Vector3(Random.Range(-5f,5f), 3, Random.Range(-5f,5f));
		// to create object instantiate funtion used
		// wants 3 arguments:
		// object
		// where it goes
		// at what rotation
		Instantiate (go, transform.position, Quaternion.identity);

		//print the location of the spawner objects
		Debug.Log(transform.position);
	}
}
