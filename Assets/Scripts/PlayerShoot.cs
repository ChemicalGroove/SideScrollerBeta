using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	
	public GameObject bullet;

	private bool shot;
	private float time;
	private float sTime;
	private float rTime;
	
	private int maxBullet;
	private int curBullet;

	public GameObject ammoFull;
	public GameObject ammo2_3;
	public GameObject ammo1_3;
	public GameObject ammo0_3;
	
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
		switch (curBullet){
				case 3:
					ammo0_3.active = false;
					ammoFull.active = true;
					break;
				case 2:
					ammoFull.active = false;
					ammo2_3.active = true;
					break;
				case 1:
					ammo2_3.active = false;
					ammo1_3.active = true;
					break;
				case 0:
					ammo1_3.active = false;
					ammo0_3.active = true;
					break;
		}
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
