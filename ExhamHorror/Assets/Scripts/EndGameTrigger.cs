using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

public class EndGameTrigger : MonoBehaviour {

	public GameObject valot;
	public GameObject isoShadow;
	public GameObject pyorivaKellari;
	
	public GameObject Whiteboards;
	public GameObject blackWhiteboards;
	
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
			
			secondShadowMan.SetActive(true);
			bonusShadowMan.SetActive(true);


		}
	}
}
