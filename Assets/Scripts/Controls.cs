using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
    private int score = 0;
    public int height = 2;

	public void Start(){
		if (this.gameObject.renderer.isVisible) {
			Destroy(this.gameObject);		
		}
	}

    public void IncrementScore() {
        this.score++;
    }

	public void OnBecameInvisible(){

			Destroy(this.gameObject);		

	}
}
