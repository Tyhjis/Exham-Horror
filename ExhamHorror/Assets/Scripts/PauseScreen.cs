using UnityEngine;
using System.Collections;

// by Santeri 
// Modified by VT

public class PauseScreen : MonoBehaviour {
	
	public bool paused = false;
	public Font font;
	private GUIStyle buttonStyle;
	public Texture2D Pausetexture;
	public AudioListener PlayerEars;
	public PlayerGUI PlayerEyes;
	
	
	void Update() {
		
		if (paused) {
			Time.timeScale = 0.0f;
			Screen.showCursor = true;
			Screen.lockCursor = false;
			
			PlayerEars.enabled = false;
			PlayerEyes.enabled = false;

		} 
		else {
			Time.timeScale = 1.0f;
			Screen.showCursor = false;
			Screen.lockCursor = true;
			
			PlayerEars.enabled = true;
			PlayerEyes.enabled = true;

		}
		
		if (Input.GetKeyDown(KeyCode.Escape)) {
			paused = !paused;
		}
	}
	
	void OnGUI() {
		if (paused) {
			Pause();
		}
	}
	
	void Pause() {
		// määritellään kustomoitu nappityyli
		if (buttonStyle == null) {
			buttonStyle = new GUIStyle(GUI.skin.button);
			buttonStyle.font = font;
			buttonStyle.normal.textColor = Color.white;
			buttonStyle.hover.textColor = Color.red;
			buttonStyle.fontSize = 75;
		}
		
		// piirretään tausta mustaksi käyttäen tekstuuria
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Pausetexture, ScaleMode.StretchToFill, true);
		
		// tehdään napeista taustoista läpinäkyviä niin, että vain teksti näkyy
		GUI.backgroundColor = Color.clear;
		
		// määritellään pausevalikon saama tila näytöllä. Tämä toimii ainakin 1024x768-resoluutiosta ylöspäin.
		
		GUILayout.BeginArea(new Rect((Screen.width * 0.5f) - (Screen.width * 0.25f), (Screen.height * 0.6f) - (Screen.height * 0.25f), Screen.width * 0.5f, Screen.height * 0.5f));
		//GUILayout.BeginArea(new Rect((Screen.width * 0.5f) - (Screen.width * 0.25f), (Screen.height * 0.5f) - (Screen.height * 0.25f), Screen.width * 0.5f, Screen.height * 0.5f));

		if (GUILayout.Button("Continue", buttonStyle)) {
			paused = !paused;
		}
		
		if (GUILayout.Button("Restart", buttonStyle)) {
			Application.LoadLevel("Game");
		}
		
		if (GUILayout.Button("Exit to menu", buttonStyle)) {
			Application.LoadLevel("Menu");
		}
		
		GUILayout.EndArea();
	}
	
}
