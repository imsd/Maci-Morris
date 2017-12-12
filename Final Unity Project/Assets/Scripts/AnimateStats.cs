using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateStats : MonoBehaviour {

	// assign the game objects that will be animated
	public Transform Belt1;
	public Transform Belt2;
	public Transform Belt3;
	public Transform Belt4;

	// beginning property for shapes
	public Vector3 startingPosition1;
	public Vector3 startingPosition2;
	public Vector3 startingPosition3;
	public Vector3 startingPosition4;


	// ending properties for shapes
	public Vector3 TargetPosition1;
	public Vector3 TargetPosition2;
	public Vector3 TargetPosition3;
	public Vector3 TargetPosition4;

	// keep track of time
	public float AnimationLength = 200f;

	// text object
	public TextMesh DisplayText1;
	public TextMesh DisplayText2;
	public TextMesh DisplayText3;
	public TextMesh DisplayText4;



	// Use this for initialization
	void Start () {

		// as an alternative to assigning in the inspector,
		// assign by finding names of game objects
		Belt1 = GameObject.Find ("Belt (1)").transform;
		Belt2 = GameObject.Find ("Belt (2)").transform;
		Belt3 = GameObject.Find ("Belt (3)").transform;
		Belt4 = GameObject.Find ("Belt (4)").transform;

		DisplayText1 = GameObject.Find ("Display Text (1)").GetComponent<TextMesh>();
		DisplayText2 = GameObject.Find ("Display Text (2)").GetComponent<TextMesh>();
		DisplayText3 = GameObject.Find ("Display Text (3)").GetComponent<TextMesh>();
		DisplayText4 = GameObject.Find ("Display Text (4)").GetComponent<TextMesh>();

		// set all scales to starting value
		Belt1.transform.localPosition = startingPosition1;
		Belt2.transform.localPosition = startingPosition2;
		Belt3.transform.localPosition = startingPosition3;
		Belt4.transform.localPosition = startingPosition4;	
	}
	
	// Update is called once per frame
	void Update () {

		// what total is that as a proportion?
		float Proportion = Time.time / AnimationLength;

		// animate using "Lerp" function which moves between two values smoothly
		Belt1.transform.localPosition = Vector3.Lerp (startingPosition1, TargetPosition1, Proportion);
		Belt2.transform.localPosition = Vector3.Lerp (startingPosition2, TargetPosition2, Proportion);
		Belt3.transform.localPosition = Vector3.Lerp (startingPosition3, TargetPosition3, Proportion);
		Belt4.transform.localPosition = Vector3.Lerp (startingPosition4, TargetPosition4, Proportion);

		// do something with the text display
		// convert the Proportion (zero to one) to a percentage (0 to 100)
		int Percentage = (int)Mathf.Round((Proportion * 100));
		// clamp it so it doesnt exceed 100
		Percentage = Mathf.Clamp (Percentage, 0, 100);
		// add a % symbol on the end
		string PercentageString = Percentage.ToString() + "%";
		// set the display text to that value
		DisplayText1.text = PercentageString;
		DisplayText2.text = PercentageString;
		DisplayText3.text = PercentageString;
		DisplayText4.text = PercentageString;
	}
}
