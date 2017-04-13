using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 0.05f;
	void Start(){

	}

	void Shoot(){
		
	}

	void Update () {
		if (Input.GetKey(KeyCode.W)){
			if (this.transform.position.y < -(2.5+0.05)){
				Vector3 position = this.transform.position;
				position.y += moveSpeed;
				this.transform.position = position;
			}
		}
		if (Input.GetKey(KeyCode.S)){
			if (this.transform.position.y > -(3.4-0.05)){
				Vector3 position = this.transform.position;
				position.y -= moveSpeed;
				this.transform.position = position;
			}
		}
	}
}