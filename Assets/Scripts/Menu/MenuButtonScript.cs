using UnityEngine;
using System.Collections;

public class MenuButtonScript : MonoBehaviour {
	public GameObject settings;
	

	// Use this for initialization
	void OnMouseDown () {
		if(this.name == "Play")
		{
			GameObject.Find("Play").guiText.enabled = false;
			GameObject.Find("Settings").guiText.enabled = false;
			GameObject.Find("Exit").guiText.enabled = false;

			GameObject.Find("Levels").guiText.enabled = true;
			GameObject.Find("Level1").guiText.enabled = true;
			GameObject.Find("Level2").guiText.enabled = true;
			GameObject.Find("Level3").guiText.enabled = true;
			GameObject.Find("Level4").guiText.enabled = true;
			GameObject.Find("LevelBack").guiText.enabled = true;
		}

		if(this.name == "Settings")
		{
			GameObject.Find("Play").guiText.enabled = false;
			GameObject.Find("Settings").guiText.enabled = false;
			GameObject.Find("Exit").guiText.enabled = false;

			GameObject.Find("SettingsBack").guiText.enabled = true;

			if (settings.GetComponent<SettingsManager>().musicMuted)
				GameObject.Find("SettingsMusicOff").guiText.enabled = true;
			else
				GameObject.Find("SettingsMusicOn").guiText.enabled = true;


		}

		if(this.name == "Exit")
		{
			Application.Quit();
		}

		if(this.name == "Level1")
		{
			Application.LoadLevel("ass");
		}

		if(this.name == "Level2")
		{
			Application.LoadLevel("ass2");
		}

		if(this.name == "Level3")
		{
			Application.LoadLevel("ass3");
		}

		if(this.name == "Level4")
		{
			Application.LoadLevel("clockwork");
		}

		if(this.name == "LevelBack")
		{
			GameObject.Find("Play").guiText.enabled = true;
			GameObject.Find("Settings").guiText.enabled = true;
			GameObject.Find("Exit").guiText.enabled = true;
			GameObject.Find("Levels").guiText.enabled = false;
			GameObject.Find("Level1").guiText.enabled = false;
			GameObject.Find("Level2").guiText.enabled = false;
			GameObject.Find("Level3").guiText.enabled = false;
			GameObject.Find("Level4").guiText.enabled = false;
			GameObject.Find("LevelBack").guiText.enabled = false;
		}

		if(this.name == "SettingsMusicOn")
		{
			settings.GetComponent<SettingsManager>().musicMuted = true;

			GameObject.Find("SettingsMusicOff").guiText.enabled = true;
			GameObject.Find("SettingsMusicOn").guiText.enabled = false;

		}

		if(this.name == "SettingsMusicOff")
		{
			settings.GetComponent<SettingsManager>().musicMuted = false;
			
			GameObject.Find("SettingsMusicOff").guiText.enabled = false;
			GameObject.Find("SettingsMusicOn").guiText.enabled = true;
			
		}

		if(this.name == "SettingsBack")
		{
			GameObject.Find("Play").guiText.enabled = true;
			GameObject.Find("Settings").guiText.enabled = true;
			GameObject.Find("Exit").guiText.enabled = true;

			GameObject.Find("SettingsMusicOff").guiText.enabled = false;
			GameObject.Find("SettingsMusicOn").guiText.enabled = false;
			GameObject.Find("SettingsBack").guiText.enabled = false;
		}
	}
}
