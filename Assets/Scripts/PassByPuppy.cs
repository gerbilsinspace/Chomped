using UnityEngine;
using System.Collections;

public class PassByPuppy : MonoBehaviour {
	bool Triggered  = false;
	public AudioClip chomp;
	public GameObject sunbeam;
	private AudioSource source;
	private float volLowRange = .5f;
	private float volHighRange = 1.0f;



	void Awake () {
		source = GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (Triggered == false&& other.tag == "Player") {
			Triggered = true;
			ScoreManager.score = ScoreManager.score + 1;

			// audio
			float audioFreq = Random.Range(volLowRange, volHighRange);
			source.PlayOneShot(chomp, audioFreq);

			// Add a sunbeam
			Instantiate (sunbeam, transform.position, transform.rotation);


		}
	}
}
