using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {

	public Texture texture;
	public float scale = 0.1f;

	void OnGUI()
	{
		//GUI.Label(new Rect (10, 10, 100, 200), "Hello World!");  
		float w = texture.width * scale;
		GUI.Label (new Rect ( Screen.width - w  - 10, Screen.height - w +190 -  10, w, w), texture);  
	}
}
