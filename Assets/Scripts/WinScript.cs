using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {
	public GUIText winText;

	void OnTriggerEnter2D(Collider2D col){
		if(winText.text.Equals("")){
		if(col.gameObject.tag == "Player"){
			if(GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Controls>().getScore() > GameObject.FindGameObjectsWithTag("Player")[1].GetComponent<Controls>().getScore())
				Win(GameObject.FindGameObjectsWithTag("Player")[0]);
			if(GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Controls>().getScore() < GameObject.FindGameObjectsWithTag("Player")[1].GetComponent<Controls>().getScore())
				Win(GameObject.FindGameObjectsWithTag("Player")[1]);
			if(GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Controls>().getScore() == GameObject.FindGameObjectsWithTag("Player")[1].GetComponent<Controls>().getScore())
					Win();
			}
		}
	}

	public void Win(GameObject gaOb){
		winText.text = gaOb.name.ToString() + " has more coins\n" + gaOb.name.ToString() +" wins";
	}

	public void Win(){
		winText.text = "Tie";
	}
}
