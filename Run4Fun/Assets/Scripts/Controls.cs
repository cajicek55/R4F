using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
    private int score = 0;
    public int height = 2;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.rigidbody2D.AddForce(Vector3.up * 3000 * height * Time.deltaTime);
            }
        }
    }

    public void IncrementScore() {
        this.score++;
    }
}
