
// IGD Valtter Taipale 2013. Modified from previous CS course

@script RequireComponent(AudioSource)

var menuPic : Texture2D;
var infoText : GUIText;
var paused = false;
var playerscript : GameObject;
var lookingScript = playerscript.GetComponent(MouseLook);


function Update () {
	if(Input.GetKeyDown("escape") && Time.timeScale == 1.0)
	{
		paused = true;
		lookingScript.enabled = false;
		
	}
	else if(Input.GetKeyDown("escape") && Time.timeScale == 0.0)
	{
		paused = false;
		lookingScript.enabled = true;
	}
}


function OnGUI () {
	if(paused == true){
		Time.timeScale = 0.0;
		if (GUI.Button (Rect (0,0, Screen.width, Screen.height), menuPic)) {
			paused = false;
			lookingScript.enabled = true;
		}
	}
	else{
		Time.timeScale = 1.0;
	}
	
}
//
//function DeactivateChildren(g: GameObject, a: boolean) {
//	g.activeSelf = a;
//
//	for (var child: Transform in g.transform) {
//		DeactivateChildren(child.gameObject, a);
//	}
//}