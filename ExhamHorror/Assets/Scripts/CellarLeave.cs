using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//Signals CellarEnter that Player has left Cellar

public class CellarLeave : MonoBehaviour {

	public CellarEnter TargetScript;
	
	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			TargetScript.PlayerIsInCellar = false;

		}
	}
	

}
