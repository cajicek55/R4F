using UnityEngine;
using System.Collections;

public class MenuCamera : MonoBehaviour {
	private bool zooming;
	private float angle;

	void Start ()
	{
		angle = Random.Range (0, 2 * Mathf.PI);
	}

	// Update is called once per frame
	void Update () 
	{
		//--Zooming-----------------------------------------------------------
		if(zooming)
		{
			Camera.main.orthographicSize += 0.002f;
		}
		else
		{
			Camera.main.orthographicSize -= 0.002f;
		}

		if((Camera.main.orthographicSize > 3) || (Camera.main.orthographicSize < 2))
		{
			zooming = !zooming;
		}
		//--Moving------------------------------------------------------------

		while((Mathf.Abs (this.transform.position.x + (Mathf.Cos(angle)/200)) > 4) || (this.transform.position.y + (Mathf.Sin(angle)/200)> 3) 
		   || (this.transform.position.y + (Mathf.Cos (angle) / 200)< -1))
		{
			angle = Random.Range (0, 2 * Mathf.PI);
		}

		this.transform.position += new Vector3 (Mathf.Cos (angle) / 200, Mathf.Sin (angle) / 200, 0);
	}
}
