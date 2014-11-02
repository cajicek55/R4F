using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	private Vector3 pos;
	private Vector3[] positions;
//	private float[] weights;
	float distance = 0;
	Vector3 max;
	Vector3 min;

	// Use this for initialization
	void Start () {
		positions = new Vector3[GameObject.FindGameObjectsWithTag("Player").Length];
//		weights = new float[positions.Length];
//		for (int i=0; i<weights.Length; i++) {
//			weights[i]=1;
//		}
	}
	
	// Update is called once per frame
	void Update () {
		//zistenie polohy vsetkych hracov
		Vector3 curPos = new Vector3(0,0,0);
		for (int i=0; i<positions.Length; i++) {
			positions[i] = GameObject.FindGameObjectsWithTag("Player")[i].transform.position;
			curPos.x += positions[i].x; //* weights[i];
			curPos.y += positions[i].y; //* weights[i];
			curPos.z += positions[i].z;
		}
		curPos.x = curPos.x / positions.Length;
		curPos.y = curPos.y / positions.Length;

		//pocitanie vah

		/*Vector3*/ max = positions[0];
		/*Vector3*/ min = positions[0];
//		for(int i=0;i<GameObject.FindGameObjectsWithTag("Player").Length;i++){
//			if(max.x < positions[i].x) max = positions[i];
//			if(min.x > positions[i].x) min = positions[i];
//		}
//		distance = Mathf.Sqrt((max.x-min.x)*(max.x-min.x)+(max.y-min.y)*(max.y-min.y));
//		curPos.x += Mathf.Abs((1/distance)*max.x);
//		curPos.y += (1/distance)*max.y;

		//pohyb kamery medzi vsetkych hracov
		Camera.main.transform.position = curPos;


		//zmensovanie Field of View
		if(Camera.main.orthographicSize > 2.5f) Camera.main.orthographicSize = Camera.main.orthographicSize - 0.0001f;
	}
}
