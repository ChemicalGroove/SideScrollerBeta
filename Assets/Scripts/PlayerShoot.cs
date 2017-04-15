using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	
	public GameObject bullet;

	private bool shot;
	private float time;
	private float interval;
	// Use this for initialization
	void Start () {
		shot = false;
		time =  0.7f;
		interval = 0.7f;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (Input.GetKeyDown("space") && (time >= interval)){
			Instantiate(bullet);
			time = Time.deltaTime;
		}
	}
}
