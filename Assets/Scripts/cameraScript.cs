using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	public float cameraSpeed = 0.05f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		position.x += cameraSpeed;
		this.transform.position = position;
	}
}
