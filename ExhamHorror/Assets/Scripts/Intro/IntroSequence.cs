using UnityEngine;
using System.Collections;

public class IntroSequence : MonoBehaviour {

	public string imagesFolder = "Intro";
	public Object[] images;
	
	private BlackFade blackFade;
	private Texture2D currentImage = null;
	private int sequencePart = 0;	
	
	private KeyCode[] skipKeys = new KeyCode[]{KeyCode.Escape, KeyCode.Return};
	
	
	void Awake () {
	
		blackFade = GetComponent<BlackFade>();
		images = Resources.LoadAll(imagesFolder, typeof(Texture2D));
		
	}
	
	void OnGUI()
	{
		CheckInput();
		SequenceControl();
		Display();
	}
	
	
	void Display()
	{
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), currentImage, ScaleMode.ScaleToFit, true);
		blackFade.Fade();
	}
	
	
	/**
	 * Hard scripted shit. Very wow. Much ugliness. Many todos.
	 */
	void SequenceControl()
	{
		CheckTrigger ();
		
		
		switch(sequencePart)
		{
		case 0:
			currentImage = (Texture2D)images[0];
			break;
			
		case 1:
			blackFade.StartFadeClear(7f);			
			break;
			
		case 2:
			blackFade.StartFadeBlack(10f);
			break;
		
		case 3:
			currentImage = (Texture2D)images[1];
			blackFade.StartFadeClear(5f);
			break;
		
		case 4:
			blackFade.StartFadeBlack(6f);
			break;
		
		case 5:
			currentImage = (Texture2D)images[2];
			blackFade.StartFadeClear(1f);
			break;
		
		case 6:
			blackFade.StartFadeBlack(3f);
			break;
			
		case 7:
			currentImage = (Texture2D)images[3];
			blackFade.StartFadeClear(4f);
			break;
		
		case 8:
			blackFade.StartFadeBlack(7f);
			break;
		
		case 9:
			currentImage = (Texture2D)images[4];
			blackFade.StartFadeClear(10f);
			break;
		
		case 10:
			blackFade.StartFadeBlack(10f);
			break;
			
		case 11:
			StartGame();
			break;
				
		default:
			break;
		}
		
	}
	
	
	/**
	 * Change sequence based on time
	 * 
	 * Times should be in seconds. I don't know anymore.
	 */
	void CheckTrigger()
	{
		if( sequencePart == 0 && Time.time >= 7 ) {
			sequencePart = 1;
			
			
		} else if( sequencePart == 1 && Time.time >= 14 ) {
			sequencePart = 2;
			
			
		} else if( sequencePart == 2 && Time.time >= 24 ) {
			sequencePart = 3;
			
			
		} else if( sequencePart == 3 && Time.time >= 30 ) {
			sequencePart = 4;
			
			
		} else if( sequencePart == 4 && Time.time >= 36 ) {
			sequencePart = 5;
			
			
		} else if( sequencePart == 5 && Time.time >= 42 ) {
			sequencePart = 6;
			
			
		} else if( sequencePart == 6 && Time.time >= 44 ) {
			sequencePart = 7;
			
			
		} else if( sequencePart == 7 && Time.time >= 47 ) {
			sequencePart = 8;
			
			
		} else if( sequencePart == 8 && Time.time >= 54 ) {
			sequencePart = 9;
			
			
		} else if( sequencePart == 9 && Time.time >= 64 ) {
			sequencePart = 10;
			
			
		} else if( sequencePart == 10 && Time.time >= 74 ) {
			sequencePart = 11;
		}
		
		
	}
	
	
	void CheckInput()
	{
		foreach( KeyCode key in skipKeys) {
			if( Input.GetKey(key)) {
				StartGame ();
			}
		}
	}
	

	void StartGame()
	{
		Application.LoadLevel(1);
	}
	
	
}

