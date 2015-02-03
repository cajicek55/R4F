using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	private int end = -1;
	private Vector3 pos;
	float distance = 0;
	Vector3 max;
	Vector3 min;
	public GUIText winText;
	public int zmensovanie = 1;

	// Use this for initialization
	void Start () {
		winText.text = "";
	}
	
	void Awake(){
		Application.targetFrameRate = 60;

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
						curPos.y = (curPos.y + Camera.main.orthographicSize - 2.5f) / GameObject.FindGameObjectsWithTag ("Player").Length;

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
						curPos.x += distance/8;

						//pohyb kamery medzi vsetkych hracov
						pos = curPos;			
						Camera.main.transform.position = pos;
						
				} else {
			if(GameObject.FindGameObjectWithTag("Player")!=null) 
			{
				Vector3 curPos = GameObject.FindGameObjectWithTag("Player").transform.position;
				curPos.z -= 100;
				pos = curPos;
				Camera.main.transform.position = pos;

			}
		}
		//vyhra jedneho z hracov
		if(winText.text.Equals("")){
			if (GameObject.FindGameObjectsWithTag ("Player").Length == 1) {
				Win (GameObject.FindGameObjectsWithTag ("Player")[0]);
			}
		}

		//zmensovanie Field of View
		if (Camera.main.orthographicSize > 2.5f)
						Camera.main.orthographicSize = Camera.main.orthographicSize - (zmensovanie/2000f); //0.0001f;
	}

	public void setEnd(int time){
		this.end = time;
	}

	public void Win(GameObject gaOb){
		winText.text = gaOb.name.ToString() + " wins";
		end = 300;
	}
}
