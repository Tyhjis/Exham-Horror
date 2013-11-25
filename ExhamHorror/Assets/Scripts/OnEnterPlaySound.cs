using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//Basic script which upon player entering a trigger zone plays a sound ONCE
//Use for all kinds of scaryness

public class OnEnterPlaySound : MonoBehaviour {

	public AudioSource TargetSound;
	
	
	
	
	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			TargetSound.Play();
			gameObject.SetActive(false);
		}
	}
}
