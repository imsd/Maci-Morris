using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayStringExample1 : MonoBehaviour {



	public string[] names;
	public string[] places;
	public string[] adverbs; 
	public string[] nouns; 
	public string[] verbs;
	public string[] names2; 
	public string[] adjective; 

	void Start () {
	// loop thru all the names
	//        for (int i = 0; i < names.Length; i++) {
	//            Debug.Log (names [i]);
	//        }

	// draw a random name from the array
	//        int rando = Random.Range(0, names.Length);
	//        Debug.Log (names [rando]);

	int randNames = Random.Range(0, names.Length);
	int randPlace = Random.Range(0, places.Length);
	int randAd = Random.Range(0, adverbs.Length);
	int randNoun = Random.Range(0, nouns.Length);
	int randVerbs = Random.Range(0, verbs.Length);
	int randNames2 = Random.Range(0, names2.Length); 
	int randAdj = Random.Range(0, adjective.Length);

	string line1 = "One day, " + names[randNames] + " went to the " +
		            places[randPlace] + "." + 
		           " While there " + names2[randNames2] + " " +  
		            adverbs[randAd] + " " +
		            verbs[randVerbs] + " " + 
		            nouns[randNoun] + "." + 	
		            "After freaking out " + names[randNames] +
		            " yelled. Bro are you " + names[randNames];







		Debug.Log (line1); 

	}

	// Update is called once per frame
	void Update () {

	}
}