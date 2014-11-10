using UnityEngine;
using System.Collections;

public class Player2Control : Controls {
    public int speed = 7;
	public bool facingRight = true;
	public bool doubleJump = false;

    void Update()
    {
		this.GetComponent<Animator>().SetInteger("Speed", (int) Mathf.Abs(Input.GetAxis ("Player2_Horizontal")));
		if ((Input.GetButton("Player2_Horizontal")) && ((this.transform.eulerAngles.z < 40) || (this.transform.eulerAngles.z > 320)))
        {
            if (Input.GetAxis("Player2_Horizontal") < 0)
            {
                //this.transform.eulerAngles = new Vector2(0, 180);
                speed = Mathf.Abs(speed);
                transform.Translate(Input.GetAxis("Player2_Horizontal") / speed * Vector3.right);

            }
            else
            {
                //this.transform.eulerAngles = new Vector2(0, 0);
                speed = -1 * Mathf.Abs(speed);
				transform.Translate(Input.GetAxis("Player2_Horizontal") / speed * Vector3.left);
            }
        }
		if (Input.GetAxis ("Player2_Horizontal") > 0 && !facingRight) {
			Flip ();
		} else if (Input.GetAxis ("Player2_Horizontal") < 0 && facingRight) {
			Flip ();		
		}

		if (doubleJump && (Input.GetAxis("Player2_Jump") > 0))
		{
			this.rigidbody2D.velocity = Vector3.zero;
			this.rigidbody2D.AddForce(Vector3.up * 7000 * height * Time.deltaTime);
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
		Rotate (Vector3.zero);
		this.rigidbody2D.AddForce(Vector3.up * 6000 * height * Time.deltaTime);
	}
}
