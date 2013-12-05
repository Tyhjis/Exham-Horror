using UnityEngine;
using System.Collections;

//IGP 2013 Valtter Taipale

//The Bad Ending of the game: 

public class VICTORY_Badend : MonoBehaviour {
	
	public GameObject ShadowCouncil;
	public ParticleSystem RecordTendrils;
	
	public AudioSource Badlaught;
	public AudioSource EndBattle;
	
	public PlayerInventory Inventory;
	public PlayerHealth Health;
	public MouseLook MouseLooking;
	
	//Flow Mechanics
	
	//Player gives the record to 
	public bool BadEndingActive = false;
	
	//Player has angered the Record Player and now Recordplayer is after Player.
	public bool EndBattleActive = false;
	
	public bool end = false;
	
	public int endCounter = 6;
	public Texture2D EndTexture;
	
	public int debugbutton = 0;
	
	void Start () {
	
	}
	

	void Update () {
		
		//Both of them cannot be active at the same time!
		if (BadEndingActive == true && EndBattleActive == true)
		{
			BadEndingActive = false;
			
		}
		
		if (BadEndingActive == true){
			
			
			//basically every fifth Update reduce health of Player
			if (endCounter > 1){
				endCounter--;
			}
			else{
				endCounter	= 5;
			}
			
			
			if (Health.health > 10 && endCounter == 5){
				Health.health--;
			}
			//The Actual Bad End. Freeze all and 
			else if (Health.health <= 10) {
				end = true;
				MouseLooking.enabled  = false;
				Time.timeScale = 0.0f;
			}
			
		}
		if (BadEndingActive == true){}
	
	}
	
	void OnTriggerEnter (Collider Recordget) {
		
		if(Recordget.gameObject.tag == "Player") 
		{
			
			if (Inventory.hasRecord == true && EndBattleActive == false) {
				
				Inventory.hasRecord = false;
				RecordTendrils.gameObject.SetActive(true);
				BadEndingActive = true;
				Badlaught.Play();
				
			}
		}
		
		if(Recordget.gameObject.tag == "Bullet" && EndBattleActive == false) 
		{		
			
			RecordTendrils.gameObject.SetActive(true);
			EndBattleActive = true;
			
			Badlaught.gameObject.SetActive(false);
			EndBattle.Play();
			
			
			
		}
		
	}
	void OnGUI () {
	
		if (end == true){
			
				if (GUI.Button (new Rect (0,0, Screen.width, Screen.height), EndTexture)) {
					Application.LoadLevel(4);
				}
		}
	}

}
