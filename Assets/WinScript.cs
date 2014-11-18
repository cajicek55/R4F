using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "Player"){
			if(GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Controls>().getScore()>GameObject.FindGameObjectsWithTag("Player")[1].GetComponent<Controls>().getScore())
				GameObject.Find("Main camera").GetComponent<CameraScript>().Win(GameObject.FindGameObjectsWithTag("Player")[0]);
			if(GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Controls>().getScore()<GameObject.FindGameObjectsWithTag("Player")[1].GetComponent<Controls>().getScore())
				GameObject.Find("Main camera").GetComponent<CameraScript>().Win(GameObject.FindGameObjectsWithTag("Player")[1]);
		}
	}
}
