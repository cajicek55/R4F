using UnityEngine;
using System.Collections;

public class JumpBoostScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.gameObject.tag == "Player")
		{
			Player2Control script = hit.GetComponent<Player2Control>();
			if(script != null)
			{
				script.jumpMult = 1.2f;
				script.jumpBoost = 360;
			}
			
			Player1Control script2 = hit.GetComponent<Player1Control>();
			if(script2 != null)
			{
				script2.jumpMult = 1.2f;
				script2.jumpBoost = 360;
			}


			GameObject.Destroy(this.gameObject);
		}
		
	}
}
