using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	private int end = -1;
	private Vector3 pos;
	float distance = 0;
	Vector3 max;
	Vector3 min;
	public GUIText winText;

	// Use this for initialization
	void Start () {
		winText.text = "";
	}
	

	void Update () {

		//--prehodenie do menu po skonceni hry-------------------------------
		if (end > 0)
		{
			end--;
		}
		if (end == 0)
		{
			Application.LoadLevel("menu");
		}
		//-------------------------------------------------------------------

		if (GameObject.FindGameObjectsWithTag ("Player").Length > 1) {
						//zistenie polohy vsetkych hracov
						Vector3 curPos = new Vector3 (0, 0, 0);
						for (int i=0; i<GameObject.FindGameObjectsWithTag("Player").Length; i++) {
								//positions[i] = GameObject.FindGameObjectsWithTag("Player")[i].transform.position;
								curPos.x += GameObject.FindGameObjectsWithTag ("Player") [i].transform.position.x;
								curPos.y += GameObject.FindGameObjectsWithTag ("Player") [i].transform.position.y;
								curPos.z += GameObject.FindGameObjectsWithTag ("Player") [i].transform.position.z;
						}
						curPos.x = curPos.x / GameObject.FindGameObjectsWithTag ("Player").Length;
//<<<<<<< HEAD
						curPos.y = (curPos.y+5) / GameObject.FindGameObjectsWithTag ("Player").Length;
//=======
				//		curPos.y = curPos.y / GameObject.FindGameObjectsWithTag ("Player").Length;
//>>>>>>> origin/master
						curPos.z = (curPos.z-100) / GameObject.FindGameObjectsWithTag ("Player").Length;

						//pocitanie "vah"


						max = GameObject.FindGameObjectsWithTag ("Player") [0].transform.position;
						min = GameObject.FindGameObjectsWithTag ("Player") [0].transform.position;
						for (int i=0; i<GameObject.FindGameObjectsWithTag("Player").Length; i++) {
								if (max.x < GameObject.FindGameObjectsWithTag ("Player") [i].transform.position.x)
										max = GameObject.FindGameObjectsWithTag ("Player") [i].transform.position;
								if (min.x > GameObject.FindGameObjectsWithTag ("Player") [i].transform.position.x)
										min = GameObject.FindGameObjectsWithTag ("Player") [i].transform.position;
						}
						distance = Mathf.Sqrt ((max.x - min.x) * (max.x - min.x) + (max.y - min.y) * (max.y - min.y));
		
						if (distance > 8) {
								curPos.x += Mathf.Abs ((1 / distance) * max.x);
//<<<<<<< HEAD
								curPos.y += (1 / distance) * max.y ;
//=======
		//						curPos.y += (1 / distance) * max.y;
//>>>>>>> origin/master
						}
						//pohyb kamery medzi vsetkych hracov
						Camera.main.transform.position = curPos;
				} else {
			//Camera.main.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position;
			Vector3 curPos = GameObject.FindGameObjectWithTag("Player").transform.position;
			curPos.z -= 100;
			Camera.main.transform.position = curPos;
		}
		//vyhra jedneho z hracov
		if(winText.text.Equals("")){
			if (GameObject.FindGameObjectsWithTag ("Player").Length == 1) {
				Win (GameObject.FindGameObjectsWithTag ("Player")[0]);
			}
		}

		//zmensovanie Field of View
		if(Camera.main.orthographicSize > 2.5f) Camera.main.orthographicSize = Camera.main.orthographicSize - 0.0001f;
	}

	public void Win(GameObject gaOb){
		winText.text = gaOb.name.ToString() + " wins";
		end = 300;
	}
}
