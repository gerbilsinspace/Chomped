using UnityEngine;
using System.Collections;

public class CheckWhereWeAre : MonoBehaviour {

	private Rigidbody2D m_Rigidbody2D;

	void Awake() {
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(m_Rigidbody2D.position.x);
	}
}
