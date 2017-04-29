using UnityEngine;
using System.Collections;

using System;

public class EnemyShoot : MonoBehaviour {

	public GameObject enBullet;

	private float time;
	private float sTime;

	public Camera cam;
	private float viewHeight;
	public float viewWidth;

	public float dist;
	public GameObject player;

	public AudioSource shoot;
	
	// Use this for initialization
	void Start () {
		cam = Camera.main;
		viewHeight = 2f * cam.orthographicSize;
		viewWidth = viewHeight * cam.aspect;
		time =  1.4f; // Current Interval
		sTime = 1.4f; // Shooting Interval
		player = GameObject.FindGameObjectWithTag("Player");
		shoot = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		dist = Vector3.Distance(gameObject.transform.position, player.transform.position);
		if (dist <= viewWidth / 3 && time >= sTime) {
				shoot.Play();
				Instantiate(enBullet, new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
				time = Time.deltaTime;
		}
	}
}
