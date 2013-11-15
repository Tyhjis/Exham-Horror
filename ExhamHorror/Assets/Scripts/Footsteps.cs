using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

	private CharacterMotor characterMotor;
	private bool walking = false;
	private bool playing = false;

	void Awake()
	{
		characterMotor = GetComponent<CharacterMotor>();	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		if( !characterMotor.IsGrounded() ||
			characterMotor.movement.velocity == Vector3.zero) {
			
			walking = false;
		} else {
			walking = true;
		}
		
		
		if( walking && !playing) {
			audio.Play();
			playing = true;
			
		} else if( !walking && playing) {
			audio.Stop();
			playing = false;
		}
		
	}
}
