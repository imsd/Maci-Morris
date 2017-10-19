using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactToVolume : MonoBehaviour
{

	// the renderer for this cube
	public Renderer rend;

	void Start ()
	{

		// at start, get the Renderer component of this object
		// and set it to rend
		rend = GetComponent<Renderer> ();

		//Select the instance of AudioProcessor and pass a reference
		//to this object
		AudioProcessor processor = FindObjectOfType<AudioProcessor> ();

		processor.onSpectrum.AddListener (onSpectrum);
	}
		
	//This event will be called every frame while music is playing
	void onSpectrum (float[] spectrum)
	{
		//The spectrum is logarithmically averaged
		//to 12 bands

		// im trying to get an average volume of the sound

		float avg = 0f;

		for (int i = 0; i < spectrum.Length; ++i) {
			avg += spectrum [i];
		}

		avg = (avg / 12) * 300;

		Debug.Log (avg);

		rend.material.color = new Color (avg, 1, 1, avg);
	}
}