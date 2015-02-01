using UnityEngine;
using System.Collections;

public class LampScript : MonoBehaviour {
	public Sprite on;
	public Sprite off;
	bool turned = true;

	int tick = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(tick == 0)
		{
			if(turned)
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = off;
				Vector3 pos = this.transform.position;
				this.transform.position = pos + new Vector3 ((-0.969f * this.transform.localScale.x), 0, 0);
			}
			else
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = on;
				Vector3 pos = this.transform.position;
				this.transform.position = pos + new Vector3 ((0.969f * this.transform.localScale.x), 0, 0);
			}

			turned = !turned;
			tick = Random.Range(5,50);
		}	

		tick--;
	}
}
