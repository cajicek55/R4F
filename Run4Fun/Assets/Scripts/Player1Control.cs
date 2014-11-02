using UnityEngine;
using System.Collections;

public class Player1Control : Controls {
    public int speed = 7;

    void Update()
    {
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
    }

    
}
