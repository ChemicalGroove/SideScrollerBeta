﻿using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	public float cameraSpeed;

	// Use this for initialization
	void Start () {
		cameraSpeed = 1f;
		/*Vector3 position = player.transform.position;
		this.transform.position = position;*/
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Player1") != null) {
			Vector3 position = this.transform.position;
			position.x += cameraSpeed * Time.deltaTime;
			this.transform.position = position;
		}
	}
}