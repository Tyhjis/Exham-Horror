using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//handles Lights and Reverb Zone of Cellar.

public class CellarEnter : MonoBehaviour {

	public GameObject CellarLights;
	public GameObject CellarReverb;
	
	public bool PlayerIsInCellar = false;
		
	
	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			PlayerIsInCellar = true;

		}
	}
	
	//Should this be a separate function as this runs every single frame?
	void Update () {
		
		if(PlayerIsInCellar == true){
			CellarLights.SetActive(true);
			CellarReverb.SetActive(true);
		}
		else{
			CellarLights.SetActive(false);
			CellarReverb.SetActive(false);
			
		}
	
	}
}
