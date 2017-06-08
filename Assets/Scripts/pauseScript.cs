using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pauseScript : MonoBehaviour {

	public GameObject[] pauseObjects;
	public GameObject[] optionsObjects;

	public Slider volumeSlider;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		optionsObjects = GameObject.FindGameObjectsWithTag("ShowOnOptions");
		hidePaused();
		hideOptions();
		volumeSlider.value = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				showPaused();
				hideOptions();
			} else if (Time.timeScale == 0) {
				Debug.Log ("high");
				Time.timeScale = 1;
				hidePaused();
				hideOptions();
			}
		}
	}


	// PLAY BUTTON

	//controls the pausing of the scene
	public void pauseControl(){
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			hidePaused();
		}
	}


	// OPTIONS BUTTON

	//controls the options menu
	public void optionsControl(){
		hidePaused();
		showOptions();
	}


	// QUIT BUTTON

	//controls the pausing of the scene
	public void quitControl(){
		Application.Quit();
	}


	// RETURN BUTTON

	//return to main pause menu
	public void returnControl(){
		hideOptions();
		showPaused();
	}
	// VOLUME SLIDER

	public void changeVolume(){
		AudioListener.volume = volumeSlider.value;
	}
	

	// SHOW

	//shows objects with ShowOnOptions tag
	public void showOptions(){
		foreach(GameObject g in optionsObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnOptions tag
	public void hideOptions(){
		foreach(GameObject g in optionsObjects){
			g.SetActive(false);
		}
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}
}
