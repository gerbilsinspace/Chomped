using UnityEngine;
using System.Collections;

public class PassByPuppy : MonoBehaviour {
	HUDScript hud;
	bool Triggered  = false;

	void Awake() {
		hud = GameObject.Find ("Main Camera").GetComponent <HUDScript> ();
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (Triggered == false&& other.tag == "Player") {
			Triggered = true;
			hud.ChangeScore (1);
		}
	}
}
