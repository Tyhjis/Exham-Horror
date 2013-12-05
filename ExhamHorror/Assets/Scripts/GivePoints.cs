using UnityEngine;
using System.Collections;

public class GivePoints : MonoBehaviour {
	
	public bool hasBeenVisited = false;
	public GameObject gramophone;	
	public PlayerInventory Inventory;
	
	public bool HasRecord = true;
	public GameObject RecordMesh;
	
	private VictoryScript victory;
	
	void OnTriggerEnter (Collider other) {
		
		if (HasRecord == true)
		{
			RecordMesh.SetActive(true);
			
		}
		else
		{
			RecordMesh.SetActive(false);
		}
		
		if(other.gameObject.tag == "Player") {
		
			if (HasRecord == false){
				if( Inventory.hasRecord == false && hasBeenVisited == false) {
	
					//Text to gui: Seems to be visiting a record to play + WAIT!
					
				}
				
				
				if( Inventory.hasRecord == true && hasBeenVisited == false) {
					hasBeenVisited = true;
					Inventory.hasRecord = false;
					victory = other.gameObject.GetComponent("VictoryScript") as VictoryScript;
					victory.incrementGramophones(1);
					gramophone.audio.enabled = false;
				}
				
				

			}
			else if (hasBeenVisited == false) {
				
				hasBeenVisited = true;
				Inventory.hasRecord = false;
				victory = other.gameObject.GetComponent("VictoryScript") as VictoryScript;
				victory.incrementGramophones(1);
				gramophone.audio.enabled = false;
			
			}
		}
	}
}
