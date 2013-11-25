using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013


public class FallDamage : MonoBehaviour {

	public PlayerHealth healthImput;

	public bool falling = false;
	
	public float fallingDamage = 10f;

	void Start () {
		
	}	
	
	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			falling = true;
		}
	}
	
	void Update () {

		if (falling == true) 
		{
			healthImput.TakeDamage(fallingDamage);
		}

	}
}
