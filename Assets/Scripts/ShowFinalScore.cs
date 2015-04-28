using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowFinalScore : MonoBehaviour {
	int finalScore;
	Text text;
	
	void Awake () {
		text = GetComponent<Text> ();
		finalScore = PlayerPrefs.GetInt("Player Score");
		
	}
	
	void Update () {
		text.text = ""+finalScore+"";
	}
}
