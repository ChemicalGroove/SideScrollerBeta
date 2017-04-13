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
	}

	/*void OnBecameInvisible() {
		// Destroy the bullet 
		Destroy(gameObject);
	}*/
}
