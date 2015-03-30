using UnityEngine;
using System.Collections;



public class GameControllerScript : MonoBehaviour {

	public float timeIncrease = 2;
	public bool timeElapsed = false;
	public GameObject[] TimerObject;
	
	public int items;
	
	void Start() {
	
	}
	
	void Update() {
		
		if (timeElapsed)
		{

		}
	}
	
	//If the game controller receives this signal from the timer, it will end the game
	void timeHasElapsed() {
		timeElapsed = true;
	}
	
}
