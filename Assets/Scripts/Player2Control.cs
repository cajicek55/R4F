using UnityEngine;
using System.Collections;

public class Player2Control : Controls {
    
    public int speed = 7;

    void Update()
    {
        if (Input.GetButton("Player2_Horizontal"))
        {
            if (Input.GetAxis("Player2_Horizontal") < 0)
            {
                //this.transform.eulerAngles = new Vector2(0, 180);
                speed = Mathf.Abs(speed);
                transform.Translate(Input.GetAxis("Player2_Horizontal") / speed * Vector3.right);

            }
            else
            {
                this.transform.eulerAngles = new Vector2(0, 0);
                speed = -1 * Mathf.Abs(speed);
                transform.Translate(Input.GetAxis("Player2_Horizontal") / speed * Vector3.left);
            }

        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            if (Input.GetAxis("Player2_Jump") > 0)
            {
                this.rigidbody2D.AddForce(Vector3.up * 3000 * height * Time.deltaTime);
            }
        }
    }
}
