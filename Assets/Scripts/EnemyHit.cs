using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj) {
		// If the enemy collided with a bullet
		if (obj.gameObject.tag == "Bullet") {
			Destroy(gameObject);
			Destroy(obj.gameObject);
		}
	}
}
