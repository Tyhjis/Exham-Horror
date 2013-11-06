using UnityEngine;
using System.Collections;

public class GramoTrigger : MonoBehaviour {

	public GameObject gramophone;
	
	void Start () {
		
	}	
	
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player") {
			gramophone.SetActive(true);
			gramophone.audio.enabled = true;
		}
	}
}
