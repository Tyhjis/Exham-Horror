using UnityEngine;
using System.Collections;

public class EnemyTrigger : MonoBehaviour {
	
	public GameObject shadowMan;
	
	private Shadowman_AI ai;
	// Use this for initialization
	void Start () {
		ai = shadowMan.GetComponent<Shadowman_AI>();
	}
	
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player") {
			ai.setDetected();
			gameObject.SetActive(false);
		}
	}
}
