using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 0.05f;

	void Start(){

	}

	void Update () {
		if (Input.GetKey(KeyCode.W)){
			Vector3 position = this.transform.position;
			position.y += moveSpeed;
			this.transform.position = position;
		}
		if (Input.GetKey(KeyCode.S)){
			Vector3 position = this.transform.position;
			position.y -= moveSpeed;
			this.transform.position = position;
		}
	}
}