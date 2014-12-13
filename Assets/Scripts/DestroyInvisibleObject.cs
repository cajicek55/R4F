using UnityEngine;
using System.Collections;

public class DestroyInvisibleObject : MonoBehaviour {

	public void OnBecameInvisible(){
		Destroy(this.gameObject);
	}
}
