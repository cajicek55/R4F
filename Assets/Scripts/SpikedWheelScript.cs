using UnityEngine;
using System.Collections;

public class SpikedWheelScript : MonoBehaviour {
	void Update () {
		transform.Rotate(Vector3.back *70 * Time.deltaTime);
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.gameObject.tag == "Player"){
			//Destroy(collider.gameObject);

			if (collider.gameObject.GetComponent<Player1Control>() != null)
			{
				collider.gameObject.GetComponent<Player1Control>().dying = true;
			}
			else
			{
				collider.gameObject.GetComponent<Player2Control>().dying = true;
			}
		}
		
}
}