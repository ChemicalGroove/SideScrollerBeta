using UnityEngine;
using System.Collections;

using System;

public class bulletScriptEnemy : MonoBehaviour {

	public float speed;
	
	private Vector3 initPos;
	private Vector3 pos;

	public Camera cam;
	private float viewHeight;
	private float viewWidth;

	// Use this for initialization
	void Start () {
		speed = 5f;
		pos = this.transform.position;
		initPos = pos;

		cam = Camera.main;
		viewHeight = 2f * cam.orthographicSize;
		viewWidth = viewHeight * cam.aspect;
	}
	
	// Update is called once per frame
	void Update () {
		pos.x -= speed * Time.deltaTime;
		this.transform.position = pos;
		//if (pos.x >= initPos.x + viewWidth / 2) Destroy(gameObject); 
		if (pos.x >= initPos.x + viewWidth / 3) Destroy(gameObject);
		//if (position.x >= 6.25) Destroy(gameObject);
	}
	void OnBecameInvisible() {
		// Destroy the bullet 
		Destroy(gameObject);
	}
}
