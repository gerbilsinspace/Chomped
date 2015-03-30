using UnityEngine;
using System.Collections;

public class ShowScore : MonoBehaviour {
	float finalScore; 

	// Use this for initialization
	void Start () {
		finalScore = PlayerPrefs.GetFloat("Player Score");
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUIStyle style = new GUIStyle ();
		style.richText = true;
		style.stretchHeight = true;
		style.stretchWidth = true;
		style.alignment = TextAnchor.MiddleCenter;

		GUILayout.Label("<size=30>"+finalScore+"</size>",style);
	}
}
