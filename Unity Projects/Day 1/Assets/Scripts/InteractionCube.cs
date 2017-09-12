using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCube : MonoBehaviour {

	public Renderer rend;
	//public Vector3 myRotation;

	public GameObject go; 

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();

	

	for (int i = 0; i < 6; i++) {
		Vector3 myVec = new Vector3 (i - 5, 2, 0);

		Instantiate (go, myVec, Quaternion.identity);
	   }
	}
	void OnMouseEnter(){
		rend.material.color = Color.red;
	}

	void OnMouseExit(){
		rend.material.color = Color.white;
	}
		
	void OnMouseOver () {
		//scale objects over three axiss
		transform.localScale += new Vector3 (.001f, .01f, .02f);
	}
		void Update(){
		//transform.Rotate ((0, 2, 2) * Time.deltaTime);	
	}
  
}
