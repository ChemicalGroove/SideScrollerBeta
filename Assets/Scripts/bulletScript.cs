using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {

	public float speed;

	public GameObject player;
	
	Vector3 position;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		position = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += speed;
		this.transform.position = position;
		if (position.x >= 6.25) Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D obj) {
		// If the enemy collided with a bullet
		if (obj.gameObject.tag == "Enemy") {
			Destroy(gameObject);
			Destroy(obj.gameObject);
		}
	}
	/*void OnBecameInvisible() {
		// Destroy the bullet 
		Destroy(gameObject);
	}*/
}
