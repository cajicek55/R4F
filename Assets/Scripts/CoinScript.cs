using UnityEngine;
using System.Collections;

public class CoinScript : CollectableScript {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	void OnTriggerEnter2D(Collider2D hit){
		if(hit.gameObject.tag == "Player"){
			if(this.gameObject.GetComponent<SpriteRenderer>().sprite.name.Equals("diamond")) for(int i=0;i<4;i++){
				hit.gameObject.GetComponent<Controls>().IncrementScore();
			}else{
				hit.gameObject.GetComponent<Controls>().IncrementScore();}
			GameObject.Destroy(this.gameObject);
		}
		
	}
}
