using UnityEngine;
using System.Collections;

public class Player1Control : Controls {
    public int speed = 7;
	public bool facingRight = true;
	public bool doubleJump = false;

	void Update()
    {

		this.GetComponent<Animator>().SetInteger("Speed", (int) Mathf.Abs(Input.GetAxis ("Player1_Horizontal")));
		if ((Input.GetButton("Player1_Horizontal")) && ((this.transform.eulerAngles.z < 40) || (this.transform.eulerAngles.z > 320)))
        {
            if (Input.GetAxis("Player1_Horizontal") < 0)
            {
                //this.transform.eulerAngles = new Vector2(0, 180);
                speed = Mathf.Abs(speed);
				transform.Translate(Input.GetAxis("Player1_Horizontal") / speed * Vector3.right);

            }
            else
            {
                //this.transform.eulerAngles = new Vector2(0, 0);
                speed = -1 * Mathf.Abs(speed);
				transform.Translate(Input.GetAxis("Player1_Horizontal") / speed * Vector3.left);
            }
        }
		if (Input.GetAxis ("Player1_Horizontal") > 0 && !facingRight) {
			Flip ();
		} else if (Input.GetAxis ("Player1_Horizontal") < 0 && facingRight) {
			Flip ();		
		}

		if (doubleJump && (Input.GetAxis("Player1_Jump") > 0))
		{
			this.rigidbody2D.velocity = Vector3.zero;
			this.rigidbody2D.AddForce(Vector3.up * 5000 * height * Time.deltaTime);
			doubleJump = false;
		}
    }

	void Flip() {
		
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		
		transform.localScale = theScale;
	}

	public void Rotate(Vector3 rot)
	{
		this.rigidbody2D.velocity = Vector2.zero;
		this.transform.eulerAngles = rot;
	}

	public void Jump()
	{
		this.rigidbody2D.velocity = Vector3.zero;
		Rotate (Vector3.zero);
		this.rigidbody2D.AddForce(Vector3.up * 5000 * height * Time.deltaTime);
	}  


	void OnCollisionStay2D(Collision2D collision)
	{
		if(!(((collision.transform.eulerAngles.z % 90) > 30) && ((collision.transform.eulerAngles.z % 90) < 60)))
		{
			if(Mathf.Abs(collision.transform.eulerAngles.z - this.transform.eulerAngles.z) > 2)
				this.Rotate(new Vector3(0, 0, collision.transform.eulerAngles.z % 30));
		}
		//this.gameObject.transform.eulerAngles = new Vector3(0,0,0);
		//Debug.Log (this.transform.InverseTransformPoint(collision.contacts[0].point));
		if(this.transform.InverseTransformPoint(collision.contacts[0].point).y < -1.5)
		{
			if(collision.gameObject.tag == "Floor")
			{
				if (Input.GetAxis("Player1_Jump") > 0)
				{
					this.Jump();
				}		



			}
		}
	}
}
