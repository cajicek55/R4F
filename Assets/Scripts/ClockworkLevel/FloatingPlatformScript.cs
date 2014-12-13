using UnityEngine;
using System.Collections;

public class FloatingPlatformScript : MonoBehaviour {
	private Vector3 curPos;
	private float i = 0;
	private bool up;
	public int start;
	private int init;

	// Use this for initialization
	void Start () {
		curPos = this.gameObject.transform.position;
		up = true;
		init = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (init >= start) {
			if (up && i < 15) {
				i += 0.1f;
				curPos.y += 0.1f; 
			}
			if (i >= 15)
				up = false;
			if (!up && i > 0) {
				i -= 0.1f;
				curPos.y -= 0.1f;
			}
			if (i < 0)
				up = true;
			this.gameObject.transform.position = curPos;
		} else
			init++;
	}
}
