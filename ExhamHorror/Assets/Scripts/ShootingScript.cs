using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {
	
	public Rigidbody projectile;
	public float projectileSpeed = 60;
	public float shootingGap = 0.5F;
	private float canFire = 0.0F;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && Time.time > canFire){
			canFire = Time.time + shootingGap;
			Rigidbody bull = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			bull.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
			gameObject.audio.Play();		
		}
	}
}
