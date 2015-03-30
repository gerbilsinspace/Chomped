using UnityEngine;
using System.Collections;

public class InstantlySwitchScene : MonoBehaviour {
	public int LevelToLoad = 2;
	public void LoadLevel() {
		Application.LoadLevel(LevelToLoad);
	}
}
