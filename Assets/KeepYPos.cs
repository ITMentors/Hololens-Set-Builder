using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepYPos : MonoBehaviour {

	private float yStartingPos;

	// Use this for initialization
	void Start () {
		yStartingPos = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(this.transform.position.x, yStartingPos, this.transform.position.z);
	}
}
