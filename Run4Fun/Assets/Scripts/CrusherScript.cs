using UnityEngine;
using System.Collections;

public class CrusherScript : MonoBehaviour {
    public bool crushing = false;
    // Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            crushing = true;
        }
        else crushing = false;

	}
}
