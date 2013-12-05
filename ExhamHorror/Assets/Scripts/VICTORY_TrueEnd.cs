using UnityEngine;
using System.Collections;

//IGP 2013 Valtter Taipale

//Victory Script of ENDGAME - Good Ending

public class VICTORY_TrueEnd : MonoBehaviour {
	
	public ParticleSystem winUP;
	public ParticleSystem winDown;
	
	public bool Victory = false;
	
	public int VictoryCountDown = 100;
	
	void OnTriggerEnter (Collider other) {
		
		if(other.gameObject.tag == "FinalGramofone") 
		{
			Victory = true;
			
			winUP.Play();
			winDown.Play();
		}
		
	}
	
	void Update () {
		
		if(Victory == true && VictoryCountDown > 0){
			
			VictoryCountDown = VictoryCountDown -1;
			
		}
		if(Victory == true && VictoryCountDown <= 0){
			
			
			Application.LoadLevel(4);
			
		}
		
		
	}
	
}
