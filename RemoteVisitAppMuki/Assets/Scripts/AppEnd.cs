using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppEnd : MonoBehaviour {

	public GameObject AppEndCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AppEndButton(){
		AppEndCanvas.SetActive (true);
	}

	public void YesButton(){
		Application.Quit ();
	}

	public void NoButton(){
		AppEndCanvas.SetActive (false);
	}
}
