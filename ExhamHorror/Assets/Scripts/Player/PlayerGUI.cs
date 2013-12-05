using UnityEngine;
using System.Collections;

// IGP Valtter Taipale 2013

//Pistol of Player


public class PlayerGUI : MonoBehaviour {
		
	
	public Texture2D Taustakuva;
	public Texture2D icon_Gun;
	public Texture2D icon_Record;
	
	public Texture2D icon_Paper1;
	public Texture2D icon_Paper2;
	public Texture2D icon_Paper3;
	public Texture2D icon_Paper4;
		
	//public double alpha = 20.0; 
	
	public PlayerInventory Inventory;

	//width dimension where drawing begins
	private int W_BeginDraw = Screen.width - 120;
	private int H_BeginDraw = Screen.height - 100;

	

	void OnGUI () {
		
	 	//Basic texture
		//GUI.color.a = alpha;
		
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Taustakuva);

	
		if (Inventory.gunAmount > 0){
			GUI.DrawTexture(new Rect(W_BeginDraw, H_BeginDraw, 100, 80), icon_Gun);
		}
		
		if (Inventory.hasRecord == true){
			GUI.DrawTexture(new Rect(W_BeginDraw - 120 , H_BeginDraw, 100, 80), icon_Record);
		}
		if (Inventory.hasPaper1== true){
			GUI.DrawTexture(new Rect(W_BeginDraw - 240, H_BeginDraw, 100, 80), icon_Paper1);
		}
		
		if (Inventory.hasPaper2 == true){
			GUI.DrawTexture(new Rect(W_BeginDraw - 360 , H_BeginDraw, 100, 80), icon_Paper2);
		}
		
		if (Inventory.hasPaper3 == true){
			GUI.DrawTexture(new Rect(W_BeginDraw - 480 , H_BeginDraw, 100, 80), icon_Paper3);
		}
		
		if (Inventory.hasPaper4 == true){
			GUI.DrawTexture(new Rect(W_BeginDraw - 600 , H_BeginDraw, 100, 80), icon_Paper4);
		}
		
	}
}
