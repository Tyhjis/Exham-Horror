using UnityEngine;
using System.Collections;

//IGP 2013 Valtter Taipale

//"Destroys" Transfrorm by first shrinking it and then disenabling it

public class EndgameSpawnPointDisappearScript : MonoBehaviour {

	public Transform Spawnpoint;
	public GameObject Gunpickup;
	
	public bool Disappearing = false;
	
	public float changefactor = 0.1f;
	
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player") 
		{
			Disappearing = true;
			Gunpickup.gameObject.SetActive(false);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Disappearing == true && Spawnpoint.localScale.x > 0.01){
			
			Spawnpoint.localScale -= new Vector3(changefactor,changefactor,changefactor);
			
			
		}
		else if (Disappearing == true && Spawnpoint.localScale.x <= 0.01){
			
			Spawnpoint.gameObject.SetActive(false);
			
			gameObject.SetActive(false);
			
			
		}
	}
}
