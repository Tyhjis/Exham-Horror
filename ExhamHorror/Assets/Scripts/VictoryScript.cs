using UnityEngine;
using System.Collections;

public class VictoryScript : MonoBehaviour {
	
	public int GramophonesVisited = 0;
	public int maxGramophones = 2;
	
	public void incrementGramophones(int quantity) {
		GramophonesVisited = GramophonesVisited + quantity;
		if (GramophonesVisited == maxGramophones) {
			endTheGame();
		}
	}
	
	// This will be called when there are no more Gramophones left to visit.
	private void endTheGame() {
		Application.LoadLevel("Endgame");
	}
}
