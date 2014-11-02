using UnityEngine;
using System.Collections;

public class CollectableScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.back *70 * Time.deltaTime);
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        collider.gameObject.GetComponent<Controls>().IncrementScore();
        GameObject.Destroy(this.gameObject);
    }
}
