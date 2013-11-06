using UnityEngine;
using System.Collections;

public class Shadowman_AI : MonoBehaviour {
	
	public GameObject player;
	public GameObject shadowman;
	
	private Vector3 direct;
	
	private float delay = 1.0f;
	private float playerOldX = 0;
	private float playerOldY = 0;
	private float playerOldZ = 0;
	public float turnSpeed = 0.2f;
	public float moveSpeed = 1.0f;
	public float proximityDist = 0.07f;
	public float slownessPerHit = 0.25f;
	public float recoverySpeed;
	private bool hasComeNear = false;
	private Quaternion desiredRotation;
	
	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//if (hasComeNear == false) {
		//	if (Mathf.Abs( player.transform.position.x - shadowman.transform.position.x ) <= proximityDist 
				//|| Mathf.Abs( player.transform.position.z - shadowman.transform.position.z ) <= proximityDist) {
				//transform.position = player.transform.position - Vector3.forward * 4f;
				//hasComeNear = true;
		//	}
		//} else if (hasComeNear == true) {
			
			shadowman.transform.rotation = getDirectionToPlayer();
			direct = getMovingDirection();
			/*
			if (playerHasMoved) {
				
			//haetaan suunta
			getDirectionToTarget(player);
				
			//käännytään jos pelaaja on liikkunut
			shadowman.transform.rotation = Quaternion.Lerp(shadowman.transform.rotation, desiredRotation, Time.deltaTime*turnSpeed);
			}
			*/
			
			//liikutaan
			shadowman.transform.Translate(direct * (moveSpeed * Time.deltaTime));
		//}
		
		//päivitetään sijainti missä oltiin
		//playerOldX = playerX();
		//playerOldY = playerY();
		//playerOldZ = playerZ();
		
	}
	
	private Quaternion getDirectionToPlayer() {
		Vector3 aimpoint = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
		aimpoint *= -1;
		return Quaternion.LookRotation(aimpoint);

	}
	
	private Vector3 getMovingDirection() {
		Vector3 direction = player.transform.position - shadowman.transform.position;
		return direction;
	}
	
	private bool playerHasMoved() {
		if (playerX() != playerOldX 
			|| playerY() != playerOldY 
			|| playerZ() != playerOldZ) {
			return true;
		}
		return false;
	}
	
	
	private float playerX() {
		return player.transform.position.x;
	}
	
	private float playerY() {
		return player.transform.position.y;
	}
	
	private float playerZ() {
		return player.transform.position.z;
	}
}
