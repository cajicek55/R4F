using UnityEngine;
using System.Collections;

public class GUITextP2Script : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if(GameObject.Find ("Player2")==null) {
			Destroy(this.gameObject);
			Destroy(GameObject.Find("druhyHracOvladanie"));
		}
		this.gameObject.GetComponent<GUIText>().text = "Current score of player 2: " + GameObject.Find("Player2").GetComponent<Controls>().getScore();
	}
}
