using UnityEngine;
using System.Collections;

public class GivePoints : MonoBehaviour {
	
	public bool hasBeenVisited = false;
	public GameObject gramophone;	
	
	private VictoryScript victory;
	
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player" && hasBeenVisited == false) {
			hasBeenVisited = true;
			victory = other.gameObject.GetComponent("VictoryScript") as VictoryScript;
			victory.incrementGramophones(1);
			gramophone.audio.enabled = false;
		}
	}
}
