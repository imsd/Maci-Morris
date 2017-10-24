using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

public class videoplay : MonoBehaviour {

	// add a .mov into your project and add it to the object,
	// then attach this script and modify

	public VideoPlayer vidp;

	void Start() {
		vidp.Play ();	// just call this whenever you need
	}
}