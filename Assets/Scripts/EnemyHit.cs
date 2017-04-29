using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

	private int hp;
	public GameObject hpFull;
	public GameObject hpHalf;
	public GameObject player;
	// Use this for initialization
	void Start () {
		hpFull.active = true;
		hpHalf.active = false;
		hp = 2;
		player = GameObject.FindGameObjectWithTag("Player");
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
				if (gameObject.tag=="shEnemy" && player.transform.GetComponent<PlayerCollision>().hp < player.transform.GetComponent<PlayerCollision>().maxHp){
					player.transform.GetComponent<PlayerCollision>().hp++;
					switch (player.transform.GetComponent<PlayerCollision>().hp){
						case 3:
							player.transform.GetComponent<PlayerCollision>().hp2_3.active = false;
							player.transform.GetComponent<PlayerCollision>().hpFull.active = true;
							break;
						case 2:
							player.transform.GetComponent<PlayerCollision>().hp1_3.active = false;
							player.transform.GetComponent<PlayerCollision>().hp2_3.active = true;
							break;
					}
				}
				Destroy(gameObject);
				Destroy(hpFull);
				Destroy(hpHalf);
			}
		}
	}
}
