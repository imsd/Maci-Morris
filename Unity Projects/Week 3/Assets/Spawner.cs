using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject go;

	public float StartAfter = 0.5f;
	public float SpawnFrequency = .3f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing () {
		Instantiate (go, transform.position, Quaternion.identity); 
	}
}
