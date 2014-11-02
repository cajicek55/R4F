using UnityEngine;
using System.Collections;

public class BreakableScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Crusher")
        {
            CrusherScript crush = collider.gameObject.GetComponent<CrusherScript>();
            if(crush.crushing == true)
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}
