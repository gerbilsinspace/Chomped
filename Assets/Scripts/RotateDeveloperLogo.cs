﻿using UnityEngine;
using System.Collections;

public class RotateDeveloperLogo : MonoBehaviour {
	public int time = 100;
	private float newTime = 0;
	// Use this for initialization
	void Start () {
		newTime ++;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * newTime / time); 
	}
}
