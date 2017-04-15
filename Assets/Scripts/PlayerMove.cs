using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 0.05f;
	
	public float cameraSpeed = 0.05f;

	void Start(){
	
	}

	void Update () {
		Vector3 position = this.transform.position;
		if (Input.GetKey(KeyCode.W)){
			if (this.transform.position.y < -(2.5+0.05)){
				position.y += moveSpeed;
				this.transform.position = position;
			}
		}
		if (Input.GetKey(KeyCode.S)){
			if (this.transform.position.y > -(3.4-0.05)){
				position.y -= moveSpeed;
				this.transform.position = position;
			}
		}

		position.x += cameraSpeed;
		this.transform.position = position;
	}
}