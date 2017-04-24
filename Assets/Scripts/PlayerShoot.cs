using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	
	public GameObject bullet;

	private bool shot;
	private float time;
	private float sTime;
	private float rTime;
	
	private float maxBullet;
	private float curBullet;
	// Use this for initialization
	void Start () {
		shot = false;
		time =  0.4f; // Current Interval
		sTime = 0.4f; // Shooting Interval
		rTime = 0.7f; // Reload Interval
		maxBullet = 3;
		curBullet = maxBullet;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (Input.GetKeyDown("space")){
			if((time >= rTime && curBullet == maxBullet) || (time >= sTime && curBullet > 0 && curBullet < maxBullet)){
				Instantiate(bullet);
				time = Time.deltaTime;
				curBullet--;
			}
		}
		if (Input.GetKeyDown(KeyCode.R)){
			time = Time.deltaTime;
			curBullet = maxBullet;
		}
	}
}
