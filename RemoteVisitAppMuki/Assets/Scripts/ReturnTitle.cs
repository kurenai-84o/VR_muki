using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnTitle : MonoBehaviour {

	public GameObject ReturnTitleCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ReturnTitleButton(){
		ReturnTitleCanvas.SetActive (true);
	}

	public void YesButton(){
		SceneManager.LoadScene ("TitleScene");
	}

	public void NoButton(){
		ReturnTitleCanvas.SetActive (false);
	}

}
