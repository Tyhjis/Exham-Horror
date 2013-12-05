using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float lifeTime = 1.0f;
	public ShadowManHealth enemyHealth;
	public float damage = 25.0f;
	// Determines how long the bullet exists in the scene.
	void Awake() {
		Destroy (gameObject, lifeTime);	
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Enemy") {
			enemyHealth = other.gameObject.GetComponent("ShadowManHealth") as ShadowManHealth;
			enemyHealth.TakeDamage(damage);
			Debug.Log("Damage dealt");
		}
	}
}
