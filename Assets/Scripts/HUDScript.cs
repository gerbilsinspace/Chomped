using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0;


	public void ChangeScore(int amount) {
		playerScore += amount;
	}

	void OnGUI() {
		GUI.Label (new Rect(100, 000, 100, 30), "Score: " + (int)(playerScore));
	}
}
