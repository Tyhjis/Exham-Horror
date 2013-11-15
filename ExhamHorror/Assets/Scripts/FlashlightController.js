#pragma strict

//Valtter Taipale 2013 IGP

class FlashlightController extends MonoBehaviour{
	 
	public var flashlight : Light;
	
	private var NextShot = 0.0f;
	public var ChargeTime = 0.5f;
	
	function Start () {
		
	}
	
	function Update() {

		if (Input.GetButton("Fire2")){
			 StopCoroutine("LightChange");
	         StartCoroutine("LightChange");
		}
	
	}
	
	function LightChange(){
	
		if (Time.time < NextShot){
		 	yield;
		}
		NextShot = Time.time + ChargeTime;
		

		if(flashlight.enabled == true){		
			flashlight.enabled = false;		
		}
		else if(flashlight.enabled == false){		
			flashlight.enabled = true;			
		}



		yield;
	
	}

}
