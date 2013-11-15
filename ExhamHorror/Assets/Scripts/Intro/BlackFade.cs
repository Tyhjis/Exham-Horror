using UnityEngine;
using System.Collections;

public class BlackFade : MonoBehaviour {

	public Texture2D blackTexture;
	
	public bool fadingBlack = false;
	public bool fadingClear = false;
	private float alphaFade = 1;
	private float fadeSpeed;
	
	
	void Awake()
	{
		GUI.color = new Color(0,0,0,1);
	}
	
	
	public void Fade()
	{
	
		if( fadingBlack) {
			FadeToBlack();
		}
		
		
		if( fadingClear) {
			FadeToClear();
		}
		
		
		if( alphaFade >= 1f && fadingBlack) {
			fadingBlack = false;
		}
		if( alphaFade <= 0f && fadingClear) {
			fadingClear = false;
		}
		
		
		GUI.color = new Color(0, 0, 0, alphaFade);
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), blackTexture);
		
	}
	
	
	void FadeToClear()
	{
		alphaFade = Mathf.Clamp01(alphaFade - Time.deltaTime / fadeSpeed);
	}
	
	
	void FadeToBlack()
	{
		alphaFade = Mathf.Clamp01(alphaFade + Time.deltaTime / fadeSpeed);
	}
	
	
	public void StartFadeBlack( float fadeSpeed)
	{
		this.fadeSpeed = fadeSpeed;
		fadingBlack = true;
		fadingClear = false;	// to avoid trying to do both at the same time
	}
	
	
	public void StartFadeClear( float fadeSpeed)
	{
		this.fadeSpeed = fadeSpeed;
		fadingClear = true;
		fadingBlack = false;
	}
}
