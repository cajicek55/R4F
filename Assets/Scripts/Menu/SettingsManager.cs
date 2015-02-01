using UnityEngine;
using System.Collections;

public class SettingsManager : MonoBehaviour {
	public bool musicMuted = false;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (this.gameObject);

		foreach (GameObject go in GameObject.FindGameObjectsWithTag("GameController")) 
		{
			if(go.GetComponent<SettingsManager>().musicMuted == true)
				musicMuted = true;

			if(!this.gameObject.Equals(go))
				Destroy(go);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject cam = GameObject.Find ("Main Camera");

		if(cam.audio != null)
		{
			if(cam.audio.mute)
			{
				if(!musicMuted)
					cam.audio.mute = false;
			}
			else
			{
				if(musicMuted)
					cam.audio.mute = true;
			}
		}	
	}
}
