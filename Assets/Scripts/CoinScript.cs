using UnityEngine;
using System.Collections;

public class CoinScript : CollectableScript {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//    void OnCollisionEnter2D(Collision2D collider)
//    {
//        collider.gameObject.GetComponent<Controls>().IncrementScore();
//        GameObject.Destroy(this.gameObject);
//    }

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.gameObject.tag == "Player"){
			hit.gameObject.GetComponent<Controls>().IncrementScore();
			GameObject.Destroy(this.gameObject);
		}
		
	}
}
