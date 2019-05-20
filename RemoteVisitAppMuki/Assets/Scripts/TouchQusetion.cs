using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TouchQusetion : MonoBehaviour {

	public GameObject hit_target;
	public GameObject MoviePlane;
	public GameObject MovieStopButton;
	public VideoPlayer vp;
	public GameObject mini_map;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame


	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit_info = new RaycastHit ();
			float max_distance = 100f;

			bool is_hit = Physics.Raycast (ray, out hit_info, max_distance); 


			if (is_hit) {
				if (hit_info.transform.name == hit_target.name) {
					//TODO: ヒットした時の処理;
					moviePlay();
				}
			}   
		}
	}

	private void moviePlay()
	{
		MoviePlane.SetActive (true); //planeをtrueのする
		MovieStopButton.SetActive(true);
		vp.Play ();
		mini_map.SetActive (false);

	}

	public void movieStop()
	{
		MoviePlane.SetActive (false); //planeをfalseのする
		MovieStopButton.SetActive(false);
		mini_map.SetActive (true);
	}

}
