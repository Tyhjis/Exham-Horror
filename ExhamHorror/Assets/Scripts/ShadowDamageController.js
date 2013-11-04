#pragma strict

public var playerHealth : PlayerHealth;
public var damageGap : float = 1.0;
public var maxDamage : float = 25;

private var damageDealTime : float = 0.0;
private var damageDivider : float = 0.0;
private var totalDamage : float = 0.0;

function OnTriggerStay (other : Collider) {
	if(other.gameObject.tag == "Player") {
		if(Time.time > damageDealTime){
			playerHealth = other.GetComponent(PlayerHealth);
			damageDivider = calculateDistanceToPlayer(other);
			Debug.Log("Distance: "+damageDivider);
			if(damageDivider < 1){
				damageDivider = 1;
			}
			totalDamage = maxDamage / damageDivider;
			playerHealth.TakeDamage(totalDamage);
			damageDealTime = Time.time + damageGap;
		}
	}
}

function calculateDistanceToPlayer (other : Collider) {
	var distance : float = Vector3.Distance(other.gameObject.transform.position, gameObject.transform.position);
	return distance;
}