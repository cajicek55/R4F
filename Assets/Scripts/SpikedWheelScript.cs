using UnityEngine;
using System.Collections;

public class SpikedWheelScript : MonoBehaviour {
<<<<<<< HEAD
	void Update () {
		transform.Rotate(Vector3.back *70 * Time.deltaTime);
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		Destroy(collider.gameObject);


=======

	void OnTriggerEnter2D(Collider2D collider){
		Destroy(collider.gameObject);
>>>>>>> origin/master
	}
}
