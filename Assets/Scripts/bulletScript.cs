using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {

	public float speed;

	public GameObject player;
	
	Vector3 position;
	// Use this for initialization
	void Start () {
		speed = 10f;
		player = GameObject.FindGameObjectWithTag("Player");
		position = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += speed * Time.deltaTime;
		this.transform.position = position;
		if (position.x >= 6.25) Destroy(gameObject);
	}
	/*void OnBecameInvisible() {
		// Destroy the bullet 
		Destroy(gameObject);
	}*/
}
