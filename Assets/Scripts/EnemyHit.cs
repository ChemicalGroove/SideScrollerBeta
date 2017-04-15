using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

	private int hp;
	// Use this for initialization
	void Start () {
		hp = 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D obj) {
		// If the enemy collided with a bullet
		if (obj.gameObject.tag == "Bullet") {
			Destroy(obj.gameObject);
			hp--;
			if (hp == 0){
				Destroy(gameObject);
			}
		}
	}
}
