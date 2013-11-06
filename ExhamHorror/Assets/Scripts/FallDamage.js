#pragma strict

//IGD Valtter Taipale 2013

public var healthImput : PlayerHealth;

public var falling : boolean = false;

public var fallingDamage = 10f;

function Start () {

}

function OnTriggerEnter(){

	falling = true;


}

function Update () {

	if (falling == true) {
	
		healthImput.TakeDamage(fallingDamage);

	}

}