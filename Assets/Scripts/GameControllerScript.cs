using UnityEngine;
using System.Collections;



public class GameControllerScript : MonoBehaviour {

	public float timeIncrease = 2;
	public bool timeElapsed = false;
	public GameObject[] TimerObject;
	
	public int items;
	
	void Start() {
		//int TimeRemaining = TimerObject.timeRemaining;
		//The timer, as a child of this gameobject, receive this and start the countdown using the timeRemaining variable
		//BroadcastMessage("Start Timer", TimeRemaining);
	}
	
	void Update() {
		
		if (timeElapsed)
		{
			//You lose!
		}
	}
	
	//If the game controller receives this signal from the timer, it will end the game
	void timeHasElapsed() {
		timeElapsed = true;
	}
	
}
