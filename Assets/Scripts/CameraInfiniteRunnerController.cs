using UnityEngine;
using System.Collections;

public class CameraInfiniteRunnerController : MonoBehaviour {

	public Transform player;
	
	// Update is called once per frame
	void Update () {

		// TODO: I have a bug which sends the player flying when the player collides with an object on its side. 
		//       Eventually, sometimes it deletes the player out of existance. This check is to see whether the player doesn't exist.
		if (!player) {
			Application.Quit();
		} else {
			transform.position = new Vector3 (player.position.x, 0, -10);
		}
	}
}
