using UnityEngine;
using System.Collections;

public class JumpArrowScript : MonoBehaviour {

	private int cooldown = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cooldown > 0) 
		{
			cooldown--;
		}

		if (cooldown == 0) 
		{
			this.gameObject.renderer.enabled = true;
			this.gameObject.collider2D.enabled = true;
			cooldown = -1;
		}
	}

	void OnTriggerEnter2D(Collider2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{

			Player2Control script = hit.GetComponent<Player2Control>();
			if(script != null)
			{
				script.doubleJump = true;
				cooldown = 120;

				this.gameObject.renderer.enabled = false;
				this.gameObject.collider2D.enabled = false;
			}

			Player1Control script2 = hit.GetComponent<Player1Control>();
			if(script2 != null)
			{
				script2.doubleJump = true;
				cooldown = 120;
				
				this.gameObject.renderer.enabled = false;
				this.gameObject.collider2D.enabled = false;
			}
		}	
	}
}
