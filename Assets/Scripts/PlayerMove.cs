using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 0.2f;
	
	public float cameraSpeed = 1f;

	void Start(){
		moveSpeed = 3f;
		cameraSpeed = 1f;
	}

	void Update () {
		Vector3 position = this.transform.position;
		if (Input.GetKey(KeyCode.W)){
			if (this.transform.position.y < -(2.5+0.05)){
				position.y += moveSpeed * Time.deltaTime;
				this.transform.position = position;
			}
		}
		if (Input.GetKey(KeyCode.S)){
			if (this.transform.position.y > -(3.4-0.05)){
				position.y -= moveSpeed * Time.deltaTime;
				this.transform.position = position;
			}
		}

		position.x += cameraSpeed * Time.deltaTime;
		this.transform.position = position;
	}
}