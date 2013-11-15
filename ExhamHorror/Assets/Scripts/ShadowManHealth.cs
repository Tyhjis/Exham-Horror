using UnityEngine;
using System.Collections;

public class ShadowManHealth : MonoBehaviour {
	
	public float health = 100F;
	public float regenerationTime = 0.0F;
	public float regenerationGap = 10.0F;
	
	private Shadowman_AI movement;
	private bool needRegeneration = false;
	public float movementScalar;
	
	void Start () {
		movement = GetComponent<Shadowman_AI>();
	}
	
	// Update is called once per frame
	void Update () {
		movementScalar = health / 100;
		if(Time.time > regenerationTime && needRegeneration) {
			Regenerate ();
		}
		movement.currentMoveSpeed = movement.defaultMoveSpeed * movementScalar;
	}
	
	public void TakeDamage(float amount) {
		health -= amount;
		if(health < 0){
			health = 0;
		}
		regenerationTime = Time.time + regenerationGap;
		needRegeneration = true;
		
	}
	
	void Regenerate() {
		if(health < 100f) {
			health += 1f;
			regenerationTime = Time.time + 0.5f;
		}
		if(health >= 100f) {
			health = 100f;
			needRegeneration = false;
		}
	}
}
