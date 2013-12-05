using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//handles most of inventory. Guns ammo handled by itself (Shootingscript)

public class PlayerInventory : MonoBehaviour {
	
	//Players gun!
	public GunController gun;
	//Gun is used to check ammo
	public GameObject gun_object;
	//object is used to turn the whole thing off!
	

	
	public PlayerGUI gui;
	
	public int gunAmount = 0;
	public bool hasRecord = false;
	public bool hasPaper1 = false;
	public bool hasPaper2 = false;
	public bool hasPaper3 = false;
	public bool hasPaper4 = false;
	
	private int whatselected = 0;
	
	/*
	 * 0 = Gun
	 * 1 = paper 1
	 * 2 = paper 2 etc.
	 * 
	 * Record doesnt have its own as it is only represened with a symbol
	*/
		

	void Update () {
		
		if (gunAmount > 0)
		{
			gun_object.SetActive(true);
		}
		else
		{
			gun_object.SetActive(false);
		}
		
		
	
	}
	
	
}
