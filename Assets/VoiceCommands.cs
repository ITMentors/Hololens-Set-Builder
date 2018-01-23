using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceCommands : MonoBehaviour {

	//The StageCollection GameObject for scaling
	public GameObject stageCollection;

	//All of the lights objects
	public GameObject mainLights;
	public GameObject sunsetLights;
	//For tracking which of the lights are on for LightsUp() and LightsDown()
	private GameObject activeLights;

	//For tracking the currently dragged object, if == null, nothing is being dragged;
	private GameObject draggingObject;

	// Use this for initialization
	void Start () {
		activeLights = mainLights;
		draggingObject = null;
		Debug.Log ("Made it into Start on VoiceCommands");
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void ScaleUp(){
		Debug.Log ("Made it into Scale Up!");
		Vector3 scale = stageCollection.transform.localScale;
		stageCollection.transform.localScale = new Vector3 (scale.x * 1.5f, scale.y * 1.5f, scale.z * 1.5f);
	}

	public void ScaleDown(){
		Debug.Log ("Made it into Scale Down!");
		Vector3 scale = stageCollection.transform.localScale;
		stageCollection.transform.localScale = new Vector3 (scale.x / 1.5f, scale.y / 1.5f, scale.z / 1.5f);
	}

	public void LoadActOneSceneOne(){
		Debug.Log ("Made it into Load act 1 scene 1!");
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Act1Scene1");
	}

	public void LoadActOneSceneTwo(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Act1Scene2");
	}

	public void LightsDown(){
		foreach (Transform light in activeLights.transform) {
			light.GetComponent<Light> ().intensity -= 0.1f;
		}
	}

	public void LightsUp(){
		foreach (Transform light in activeLights.transform) {
			light.GetComponent<Light> ().intensity += 0.1f;
		}
	}

	public void MainLightsOn(){
		activeLights = mainLights;
		mainLights.SetActive (true);
		sunsetLights.SetActive (false);
	}

	public void SunsetLightsOn(){
		activeLights = sunsetLights;
		mainLights.SetActive (false);
		sunsetLights.SetActive (true);
	}

	public void UpdateDragging(string objectBeingDragged){
		Debug.Log ("UpdateDragging is being called with a value of: " + objectBeingDragged);
		if (objectBeingDragged != "null") {
			Debug.Log ("Object Being Dragged from Voice is: " + objectBeingDragged);
			draggingObject = GameObject.Find (objectBeingDragged);
		} else {
			draggingObject = null;
		}
	}

	public void ScaleThisUp(){
		if (draggingObject != null) {
			draggingObject.transform.localScale = new Vector3 (draggingObject.transform.localScale.x * 1.2f, draggingObject.transform.localScale.y * 1.2f, draggingObject.transform.localScale.z * 1.2f);
		} else {
			Debug.Log ("There is nothing selected!");
		}
	}

	public void ScaleThisDown(){
		if (draggingObject != null) {
			draggingObject.transform.localScale = new Vector3 (draggingObject.transform.localScale.x / 1.2f, draggingObject.transform.localScale.y / 1.2f, draggingObject.transform.localScale.z / 1.2f);
		} else {
			Debug.Log ("There is nothing selected!");
		}
	}

}
