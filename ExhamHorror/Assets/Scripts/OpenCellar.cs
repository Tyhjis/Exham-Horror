using UnityEngine;
using System.Collections;

public class OpenCellar : MonoBehaviour {

	public GameObject cellarDoor;
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			cellarDoor.gameObject.SetActive(false);
		}
	}
}
