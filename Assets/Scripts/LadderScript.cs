using UnityEngine;
using System.Collections;

public class LadderScript : MonoBehaviour 
{	
	void OnTriggerStay2D(Collider2D hit)
	{
		if(hit.gameObject.tag == "Player")
		{
			
			Player2Control script = hit.GetComponent<Player2Control>();
			if(script != null)
			{
				script.doubleJump = true;
			}
			
			Player1Control script2 = hit.GetComponent<Player1Control>();
			if(script2 != null)
			{
				script2.doubleJump = true;
			}
		}	
	}
}
