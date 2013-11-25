using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//Basic script which upon player entering a trigger zone either Activates or Disables another Gameobject


public class OnEnterActOrDis : MonoBehaviour {
	
	public GameObject changeTarget;
	
	// difficult to name. Basically is it ACTIVE True 
	public bool endresult;
		
	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			changeTarget.gameObject.SetActive(endresult);
			gameObject.SetActive(false);
		}
	}
	
}
