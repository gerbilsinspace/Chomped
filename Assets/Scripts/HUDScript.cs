using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	private float playerScore = 0;
	public static float timer = 10;

	public void ChangeScore(int amount) {
		playerScore += amount;

	}

	void Update() {
		timer -= Time.deltaTime;

		if (timer <= 0) {
			timer = 0;
			PlayerPrefs.SetFloat("Player Score", playerScore);
			Application.LoadLevel(3);
		} 
	}

	void OnGUI() {
		GUI.Label (new Rect(100, 0, 100, 30), "Score: " + (int)(playerScore));

		string minutes = Mathf.Floor(timer / 60).ToString("00");
		string seconds = Mathf.Floor(timer % 60).ToString("00");
		GUI.Label(new Rect(200,0,250,100), minutes + ":" + seconds);


	}
}
