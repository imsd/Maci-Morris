using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatExample : MonoBehaviour
{

	// the renderer for this cube
	public Renderer rend;
//	public float xposition;
//	public float yposition;
//	public float zposition;
	public float movementspeed = 0.5f;
//	public GameObject go;


	void Start ()
	{

		// at start, get the Renderer component of this object
		// and set it to rend
		rend = GetComponent<Renderer> ();

		//Select the instance of AudioProcessor and pass a reference
		//to this object
		AudioProcessor processor = FindObjectOfType<AudioProcessor> ();
		processor.onBeat.AddListener (onOnbeatDetected);
		processor.onSpectrum.AddListener (onSpectrum);
	}

	//this event will be called every time a beat is detected.
	//Change the threshold parameter in the inspector
	//to adjust the sensitivity
	void update() {

		//Vector3 myvec = new Vector3(xposition,yposition,zposition);

	}
	void onOnbeatDetected ()
	{
		
		rend.material.color = Random.ColorHSV();
		transform.Translate(movementspeed,0,0);
	}

	//This event will be called every frame while music is playing
	void onSpectrum (float[] spectrum)
	{
		//The spectrum is logarithmically averaged
		//to 12 bands

		for (int i = 0; i < spectrum.Length; ++i) {
			Vector3 start = new Vector3 (i, 0, 0);
			Vector3 end = new Vector3 (i, spectrum [i], 0);
			Debug.DrawLine (start, end);
		}
	}
}

