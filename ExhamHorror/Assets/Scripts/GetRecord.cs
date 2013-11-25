using UnityEngine;
using System.Collections;


// IGP Valtter Taipale 2013

//On approac of the Record, player picks it up.


public class GetRecord : MonoBehaviour {
	
	public PlayerInventory Inventory;
	public AudioSource gettingsound;

	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			Inventory.hasRecord = true;
			
			gettingsound.Play();
			
			gameObject.SetActive(false);
		}
	
	}
}
