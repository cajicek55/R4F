using UnityEngine;
using System.Collections;

public class RotatingPlatformScript : MonoBehaviour {
	//private Transform curPos;
	private float i = 0;
	private bool cw;
	private float limit = 4;
	private float step = 0.25f;

	// Use this for initialization
	void Start () {
		//curPos = this.gameObject.transform;
		cw = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (cw && i < limit) {
			i += 0.1f;
			this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x,this.gameObject.transform.eulerAngles.y,this.gameObject.transform.eulerAngles.z) + new Vector3(0,0,step);
			//this.gameObject.transform.eulerAngles.x += 0.1f; 
		}
		if (i >= limit)
			cw = false;
		if (!cw && i > -limit) {
			i -= 0.1f;
			this.gameObject.transform.eulerAngles = new Vector3(this.gameObject.transform.eulerAngles.x,this.gameObject.transform.eulerAngles.y,this.gameObject.transform.eulerAngles.z) - new Vector3(0,0,step);
			//this.gameObject.transform.eulerAngles.x -= 0.1f;
		}
		if (i < -limit)
			cw = true;
		//this.gameObject.transform = curPos;
	}
}
