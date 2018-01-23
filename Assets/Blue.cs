using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour {

	TextMesh textMesh;

	// Use this for initialization
	void Start () {
		textMesh = GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoBlue() {
		textMesh.color = Color.blue;
	}
}
