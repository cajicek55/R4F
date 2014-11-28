using UnityEngine;
using System.Collections;

public class PlayerJumpControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Floor")
		{
			Player1Control par1 = GetComponentInParent<Player1Control>();
			if(par1 != null)
			{
				if(!((collision.transform.eulerAngles.z > 40) && (collision.transform.eulerAngles.z < 320)))
					par1.Rotate(collision.transform.eulerAngles);
			}

			Player2Control par2 = GetComponentInParent<Player2Control>();
			if(par2 != null)
			{
				if(!((collision.transform.eulerAngles.z > 40) && (collision.transform.eulerAngles.z < 320)))
					par2.Rotate(collision.transform.eulerAngles);
			}

			if (Input.GetAxis("Player1_Jump") > 0)
			{
				if(par1 != null)
				{
					par1.Jump();
					return;
				}
			}
			if (Input.GetAxis("Player2_Jump") > 0)
			{
				if(par2 != null)
				{
					par2.Jump();
					return;
				}
			}
		}
	}
}
