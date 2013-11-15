#pragma strict

//IGD Valtter Taipale 2013

public var healthImput : PlayerHealth;

public var fadeTexture : Texture2D;

public var alpha = 100.0; 

function Start () {

}

function Update () {

}

function OnGUI () {

	alpha = 1 - (1 - (1f-healthImput.health/100));	
	alpha = Mathf.Clamp01(alpha);	
 
	GUI.color.a = alpha;
	
	GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), fadeTexture);

}