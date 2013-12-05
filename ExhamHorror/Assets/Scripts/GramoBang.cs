using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//Gramo Shadow Dissapearance

public class GramoBang : MonoBehaviour {
	
	//The Give Points Script of Gramophone
	public GivePoints Gramo;
	
	//The Mesh of Gramophone
	public GameObject GramoMesh;
	
	//The Particles
	public GameObject GramofoneBang;
	
	//Sound
	public AudioSource GramofoneScream;
	
	public bool hasFired = false;

	void Update () {
	
		if (Gramo.hasBeenVisited == true && hasFired == false){			
			
			hasFired = true;
			
			GramofoneBang.gameObject.SetActive(true);
			GramofoneScream.Play();
			
			GramoMesh.SetActive(false);
		}
		
	}
}

