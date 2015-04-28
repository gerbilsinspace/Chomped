using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManager : MonoBehaviour {
	public static float timer = 120;
	Text text;
	string minutes;
	string seconds;
	// Use this for initialization
	void Awake () {
		timer = 120;
		text = GetComponent<Text> ();
		minutes = Mathf.Floor(timer / 60).ToString("00");
		seconds = Mathf.Floor(timer % 60).ToString("00");
		text.text = minutes + ":" + seconds;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		minutes = Mathf.Floor(timer / 60).ToString("00");
		seconds = Mathf.Floor(timer % 60).ToString("00");
		text.text = minutes + ":" + seconds;

		if (timer <= 0) {
			timer = 0;
			minutes = Mathf.Floor(timer / 60).ToString("00");
			seconds = Mathf.Floor(timer % 60).ToString("00");

			PlayerPrefs.SetFloat("Player Score", ScoreManager.score);
			Application.LoadLevel(4);
		}
	}
}
