using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//For the ENDGAME of Excactum Level.. Not the best name currently

public class EndGameTrigger : MonoBehaviour {

	public GameObject valot;
	public GameObject isoShadow;
	public GameObject pyorivaKellari;
	
	public GameObject Whiteboards;
	public GameObject blackWhiteboards;
	public GameObject DarkClouds;
	
	public GameObject secondShadowMan;
	
	// Yep, this is a bonus!
	public GameObject bonusShadowMan;
	
	void Start () {
		
	}	
	
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player") 
		{
			valot.SetActive(false);
			
			isoShadow.SetActive(true);
			pyorivaKellari.SetActive(false);
			
			blackWhiteboards.SetActive(true);
			Whiteboards.SetActive(false);
			
			DarkClouds.SetActive(true);
			
			secondShadowMan.SetActive(true);
			bonusShadowMan.SetActive(true);


		}
	}
}
