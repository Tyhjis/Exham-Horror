using UnityEngine;
using System.Collections;

// by Santeri
//
// tagit pitää olla kunnossa!

public class MenuItem : MonoBehaviour {
	
	// asetetaan oikea näkymä heti alkuun
	void Start() {
		showMenu();
	}
	
	// valittavien kohteiden värinmuutos (tekijöiden nimillä tai pelin nimellä ei ole collideria)
	void OnMouseEnter() 
	{
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit() 
	{
		renderer.material.color = Color.white;
	}
	
	void OnMouseDown()
	{
		if (gameObject.tag == "txt_newgame") {
			// oletuksena, että intro on 0, päämenu 1 ja itse peli 2
			Application.LoadLevel(2);
		}
		
		if (gameObject.tag == "txt_credits") {
			showCredits();
		}
		
		if (gameObject.tag == "txt_quit") {
			Application.Quit();
		}
		
		if (gameObject.tag == "txt_back") {
			showMenu();
		}
	}
	
	// valikko piiloon ja tekijöiden nimet esiin
	void showCredits() {
		GameObject.Find("Text_title").renderer.enabled = false;
		GameObject.Find("Text_newgame").renderer.enabled = false;
		GameObject.Find("Text_credits").renderer.enabled = false;
		GameObject.Find("Text_quit").renderer.enabled = false;
		GameObject.Find("Text_valtter").renderer.enabled = true;
		GameObject.Find("Text_kristian").renderer.enabled = true;
		GameObject.Find("Text_kasper").renderer.enabled = true;
		GameObject.Find("Text_santeri").renderer.enabled = true;
		GameObject.Find("Text_back").renderer.enabled = true;
	}
	
	// nimet piiloon ja valikko esiin
	void showMenu() {
		GameObject.Find("Text_title").renderer.enabled = true;
		GameObject.Find("Text_newgame").renderer.enabled = true;
		GameObject.Find("Text_credits").renderer.enabled = true;
		GameObject.Find("Text_quit").renderer.enabled = true;
		GameObject.Find("Text_valtter").renderer.enabled = false;
		GameObject.Find("Text_kristian").renderer.enabled = false;
		GameObject.Find("Text_kasper").renderer.enabled = false;
		GameObject.Find("Text_santeri").renderer.enabled = false;
		GameObject.Find("Text_back").renderer.enabled = false;
	}
	
}