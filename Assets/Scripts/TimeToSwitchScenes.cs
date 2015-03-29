using UnityEngine;
using System.Collections;

public class TimeToSwitchScenes : MonoBehaviour {
	public float SwitchSceneTime = 4;
	public int SceneToSwitchTo;
	void Update() {
		SwitchSceneTime -= Time.deltaTime;
		if (SwitchSceneTime <= 0) {
			SwitchSceneTime = 0;
			Application.LoadLevel(SceneToSwitchTo);
		} 
	}
}
