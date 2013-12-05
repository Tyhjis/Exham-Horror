using UnityEngine;
using System.Collections;

	// IGP Valtter Taipale
	// Triggerzone what enables EndCatedral

public class EndGameCatedralArrive : MonoBehaviour {

	public Transform Catedral;
	public bool hasfired = false;
	public float changefactor = 0.1f;
	
	public ParticleSystem CatedralBoom;
	public AudioSource CatedralArriveSound;
	
	public GameObject Silencetrigger;

	void Update () {
		
		if (hasfired == true && Catedral.localScale.x < 2.653574 && Catedral.localScale.y < 2.653574 && Catedral.localScale.z < 2.653574){

			Catedral.localScale += new Vector3(changefactor,changefactor,changefactor);
			
		}
		if (hasfired == true && Catedral.localScale.x > 2.653574 && Catedral.localScale.y > 2.653574 && Catedral.localScale.z > 2.653574){

			Catedral.localScale = new Vector3(2.653574f,2.653574f,2.653574f);
		}
	}
	
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player" && hasfired == false) 
		{
				hasfired = true;
				Catedral.gameObject.SetActive(true);
				CatedralBoom.gameObject.SetActive(true);
				CatedralArriveSound.Play(); 
				//Silencetrigger.SetActive(true);
						

					
		}
	}
}
