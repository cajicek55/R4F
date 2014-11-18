using UnityEngine;
using System.Collections;

public class Crusher2Script : MonoBehaviour {

	public bool crushing = false;
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire2"))
		{
			crushing = true;
		}
		else crushing = false;
		
	}
}
