using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public int maxHp;
	public int hp;

	// Use this for initialization
	void Start () {
		maxHp = 3;
		hp = maxHp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.gameObject.tag == "Enemy") {
			hp--;
			if (hp == 0){
				Destroy(gameObject);
			}
		}
	}
}
