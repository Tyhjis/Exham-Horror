using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//Opens Cellar and turns on all cellarlights

public class OpenCellar : MonoBehaviour {
	
	//The Give Points Script of First Gramophone
	public GivePoints FirstGramophone;
	
	public bool ThisTriggerHasFired = false;
	
	public GameObject cellarDoor;
	public GameObject cellarLights;
	
	//Two different signs which both read Elevator
	public GameObject cellarSignBefore;
	public GameObject cellarSignAfter;
	
	public AudioSource cellarPling;
	public double pingWait = 20.0;
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			
			if ( FirstGramophone.hasBeenVisited == true && ThisTriggerHasFired == false)
			{
				//WaitForSeconds;
				cellarPling.PlayScheduled(pingWait);
				cellarDoor.gameObject.SetActive(false);
				cellarLights.gameObject.SetActive(true);
				
				cellarSignBefore.gameObject.SetActive(false);
				cellarSignAfter.gameObject.SetActive(true);
				
				ThisTriggerHasFired = true;
				gameObject.SetActive(false);
			}
			

		}
		
	}
}
