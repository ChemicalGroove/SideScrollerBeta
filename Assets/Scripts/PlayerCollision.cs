using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public int maxHp;
	public int hp;

	public GameObject hpFull;
	public GameObject hp2_3;
	public GameObject hp1_3;
	public GameObject hp0_3;

	public GameObject player;

	// Use this for initialization
	void Start () {
		maxHp = 3;
		hp = maxHp;
		hpFull.active = true;
		hp2_3.active = false;
		hp1_3.active = false;
		hp0_3.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.gameObject.tag == "Enemy" || obj.gameObject.tag == "enBullet") {
			hp--;
			switch (hp){
				case 2:
					hpFull.active = false;
					hp2_3.active = true;
					break;
				case 1:
					hp2_3.active = false;
					hp1_3.active = true;
					break;
				case 0:
					hp1_3.active = false;
					hp0_3.active = true;
					//Destroy(gameObject);
					Time.timeScale = 0;
					break;
			}
			if (hp > 0)	{
				//player = GameObject.Find("player1");
				Animator animationObj = gameObject.GetComponentInChildren<Animator>();
				animationObj.SetTime (1);
				animationObj.Play("Player Hit");
			}
			if (obj.gameObject.tag == "enBullet") Destroy(obj.gameObject);
		}
	}
}
