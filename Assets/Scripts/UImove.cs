using UnityEngine;
using System.Collections;

public class UImove : MonoBehaviour {

	public float uiSpeed;

	// Use this for initialization
	void Start () {
		uiSpeed = 1f;
		/*Vector3 position = player.transform.position;
		this.transform.position = position;*/
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Player1") != null) {
			Vector3 position = this.transform.position;
			position.x += uiSpeed * Time.deltaTime;
			this.transform.position = position;
		}
	}
}
