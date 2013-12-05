using UnityEngine;
using System.Collections;

public class Shadowman_AI : MonoBehaviour {
	
	public GameObject player;
	public GameObject shadowman;

	public float recoveryDelay = 5.0f;
	private float recoveryCounter = 5.0f;
	public float timeBeforeAttack = 5.0f;
	//public float turnSpeed = 0.2f;
	public float defaultMoveSpeed = 1.0f;
	public float currentMoveSpeed = 1.0f;
	//public float proximityDist = 0.07f;
	public float slownessPerHit = 0.25f;
	public float recoverySpeed = 0.2f;
	public bool detected = false;
	
	
	void Start () {

	}
	
	void Update () {
		
		// Jos pelaaja on huomattu..
		if (detected == true) {
			// ..ja viive huomaamisesta hyökkäämiseen on kulunut umpeen,...
			if (timeBeforeAttack <= 0) {
				// ..käydään päälle..
				transform.LookAt(player.transform); // LookAt-metodi ottaisi vastaan myös toisen, ns. worldUp-parametrin, jonka pitäisi kertoa miten pidetään "pää pystyssä". En osaa.
				transform.position = Vector3.MoveTowards(transform.position, player.transform.position, currentMoveSpeed * Time.deltaTime);
			} else {
				// ..tai muuten kulutetaan viivettä ennen hyökkäystä.
				if (timeBeforeAttack > 0) {
					timeBeforeAttack = timeBeforeAttack - Time.deltaTime;
				}
			}
		}
		
		// kutsutaan recovery-metodia mahdollisen hidastumisen kumoamiseksi ajallaan
//		recovery ();
		
	}
	
	// ACHTUNG!! jonkin triggerin pitäisi laukaista tämä!!
	public void setDetected() {
		detected = true;
	}
	
	// kun osutaan aseella, hidastetaan shadowmania
	public void isHit() {
//		if (currentMoveSpeed >= 0.25f) {
//			currentMoveSpeed = currentMoveSpeed - slownessPerHit;
//		}
	}
	
	
	// metodi joka palauttaa shadowmanin nopeuden
//	private void recovery() {
//		if (currentMoveSpeed < defaultMoveSpeed) {
//			// lasketaan aikaa seuraavaan nopeudenkasvatukseen
//			recoveryCounter = recoveryCounter - Time.deltaTime;
//			// jos ollaan nollassa tai alle, kasvatetaan shadowmanin nopeutta ja asetetaan ajanotto alkuun
//			if (recoveryCounter <= 0) {
//				currentMoveSpeed = currentMoveSpeed + recoverySpeed;
//				recoveryCounter = recoveryDelay;
//			}
//		}
//	}
}
