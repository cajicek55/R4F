using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Static Background")]
public class StaticBackgroundScript : MonoBehaviour {
	public Texture2D background;
	
	void OnPreRender (){
		if( background != null )
			Graphics.Blit( background, RenderTexture.active );
	}
	
}