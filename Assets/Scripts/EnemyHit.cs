using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

	private int hp;
	public GameObject hpFull;
	public GameObject hpHalf;
	// Use this for initialization
	void Start () {
		hpFull.active = true;
		hpHalf.active = false;
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
			hpFull.active = false;
			hpHalf.active = true;
			if (hp == 0){
				Destroy(gameObject);
				Destroy(hpFull);
				Destroy(hpHalf);
			}
		}
	}
}
