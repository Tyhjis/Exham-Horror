using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

	public Rigidbody projectile;
	public AudioSource gunshot;
	public AudioSource empty;
	public float projectileSpeed = 60;
	public float shootingGap = 0.5F;
	public int ammo = 40;
	private float canFire = 0.0F;
	
	
	void Start () {
		gunshot = gameObject.audio;
	}
	// Update is called once per frame
	void Update () {
		//BANG!
		if(Input.GetButtonDown("Fire1") && Time.time > canFire && (ammo > 0)){
			canFire = Time.time + shootingGap;
			Rigidbody bull = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			bull.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
			ammo--;
			gunshot.audio.Play();		
		}
		//If no ammo just play click!
		if(Input.GetButtonDown("Fire1") && Time.time > canFire && ammo <= 0)
		{
			canFire = Time.time + shootingGap*3;
			empty.audio.Play();		
		}
		//Or if multiple pistols throw current away and draw another?
	}
}
