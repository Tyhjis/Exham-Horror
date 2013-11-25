using UnityEngine;
using System.Collections;


// IGP Valtter Taipale 2013

//On approac of a Gun, player picks it up. This is coded by putting gun amounts +1 and destryoing the gun


public class GetGun : MonoBehaviour {
	
	public PlayerInventory Inventory;
	public AudioSource gettingsound;

	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			Inventory.gunAmount++;
			
			gettingsound.Play();
			
			gameObject.SetActive(false);
		}
	
	}
}
