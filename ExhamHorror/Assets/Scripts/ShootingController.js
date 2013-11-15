#pragma strict

//Valtter Taipale 2013 IGP

class ShootingController extends MonoBehaviour{
	 
	public var projectile : Rigidbody;
	public var shooter : Transform;
	public var projectileSpeed = 80;
	
	
	private var NextShot = 0.0f;
	public var ChargeTime = 0.5f;
	
	function Start () {
		
	}
	
	function Update() {

		if (Input.GetButton("Fire1")){
		
			if (Time.time > NextShot){
				 StopCoroutine("Shoot");
		         StartCoroutine("Shoot");
		         NextShot = Time.time + ChargeTime;
	        }
		}
	
	}
	
	function Shoot(){
	
		var bullet : Rigidbody;
		bullet = Instantiate (projectile, transform.position , transform.rotation); 
	
		//var directionVector = new Vector3(shooter.transform.forward);
		
		//bullet.velocity = transform.TransformDirection (shooter.transform.forward * projectileSpeed);
		bullet.rigidbody.AddForce(shooter.transform.forward * projectileSpeed);
		yield;
	
	}

}
