using UnityEngine;
using System.Collections;

public class GuiTextScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("Player1")==null){
			Destroy(this.gameObject);
			Destroy(GameObject.Find("prvyHracOvladanie"));
		}
		this.gameObject.GetComponent<GUIText>().text = "Current score of player 1: " + GameObject.Find("Player1").GetComponent<Controls>().getScore();
	}
}
