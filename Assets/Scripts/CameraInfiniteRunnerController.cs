using UnityEngine;
using System.Collections;

public class CameraInfiniteRunnerController : MonoBehaviour {

	public Transform player;
	
	// Update is called once per frame
	void Update () {
		if (player) {
			transform.position = new Vector3 (player.position.x, 0, -10);
		}
	}
}
