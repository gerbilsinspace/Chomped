using UnityEngine;
using System.Collections;

public class PushPlayerBackUp : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (transform.position.y < 10) {
			transform.position = new Vector3(transform.position.x, 10, transform.position.z);
		}
	}
}
