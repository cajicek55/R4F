using UnityEngine;
using System.Collections;

public class WarningScript : MonoBehaviour {
	public GUIText text;
	//private int timer = 200;

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.gameObject.tag == "Player"){
			text.text = "Floating platform ahead";
		}


	}

	void OnTriggerExit2D(Collider2D hit){
		if(hit.gameObject.tag == "Player"){
			text.text = "";
		}

	}
}
