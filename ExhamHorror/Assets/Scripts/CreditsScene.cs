using UnityEngine;
using System.Collections;

public class CreditsScene : MonoBehaviour {

	public AudioSource Zarathusta;
		
	public Light Sun;
	public Light Rsun1;
	public Light Rsun2;
	
	public bool CreditsGo = false;
	
	public Transform Monoliths;
	public float changeAmount = 0.05f;
	
	public int Counter = 0;
	
	
	
	// Update is called once per frame
	void Update () {
		
		Counter++;
		
		
		if (Monoliths.localPosition.y < 18 && Counter > 1400)
		{
			Monoliths.localPosition += new Vector3(0.0f,changeAmount,0.0f);
			
		}
		
		if (CreditsGo == true && Zarathusta.isPlaying == false){
			
			Application.LoadLevel(0);
			
		}
	}
	
	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "Player") 
		{
			CreditsGo = true;
			Rsun1.gameObject.SetActive(true);
			Rsun2.gameObject.SetActive(true);
			
			Zarathusta.Play();
		}
	}
}
