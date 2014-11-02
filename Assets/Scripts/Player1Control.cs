using UnityEngine;
using System.Collections;

public class Player1Control : Controls {
    public int speed = 7;
	public bool facingRight = true;
	public Animator anim;

    void Update()
    {
		this.GetComponent<Animator>().SetInteger("Speed", (int) Mathf.Abs(Input.GetAxis ("Player1_Horizontal")));
        if (Input.GetButton("Player1_Horizontal"))
        {
            if (Input.GetAxis("Player1_Horizontal") < 0)
            {
                //this.transform.eulerAngles = new Vector2(0, 180);
                speed = Mathf.Abs(speed);
                transform.Translate(Input.GetAxis("Player1_Horizontal") / speed * Vector3.right);

            }
            else
            {
                this.transform.eulerAngles = new Vector2(0, 0);
                speed = -1 * Mathf.Abs(speed);
                transform.Translate(Input.GetAxis("Player1_Horizontal") / speed * Vector3.left);
            }
        }
		if (Input.GetAxis ("Player1_Horizontal") > 0 && !facingRight) {
			Flip ();
		} else if (Input.GetAxis ("Player1_Horizontal") < 0 && facingRight) {
			Flip ();		
		}
    }

	void Flip() {
		
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		
		transform.localScale = theScale;
	}

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            if (Input.GetAxis("Player1_Jump") > 0)
            {
                this.rigidbody2D.AddForce(Vector3.up * 1500 * height * Time.deltaTime);
            }
        }
    }

    
}
