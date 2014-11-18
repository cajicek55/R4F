using UnityEngine;
using System.Collections;

public class SpikedWheelScript : MonoBehaviour {
	void Update () {
		transform.Rotate(Vector3.back *70 * Time.deltaTime);
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.tag == "Player"){
			Destroy(collider.gameObject);
		}
		
}
}