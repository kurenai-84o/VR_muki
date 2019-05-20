using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchArrow : MonoBehaviour {

	public GameObject hit_target;
	public GameObject Button;	//ButtonについてるPointClickの関数を利用するため

    public GameObject Arrow9N;
	public GameObject Arrow10N;
	public GameObject Arrow11N;
	public GameObject Arrow12N;
	public GameObject Arrow13N;
	public GameObject Arrow14N;
    public GameObject Arrow14R;
	public GameObject Arrow15N;
    public GameObject Arrow16N;
    public GameObject Arrow17N;
    public GameObject Arrow19N;
	public GameObject Arrow26N;
	public GameObject Arrow28N;
	public GameObject Arrow29B;
	public GameObject Arrow28B;
    public GameObject Arrow28R;
    public GameObject Arrow27B;
    public GameObject Arrow26B;
	public GameObject Arrow19B;
    public GameObject Arrow17B;
    public GameObject Arrow16B;
    public GameObject Arrow15B;
    public GameObject Arrow14B;
	public GameObject Arrow13B;
	public GameObject Arrow12B;
	public GameObject Arrow11B;
    public GameObject Arrow10B;
    public GameObject Arrowtateana;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit_info = new RaycastHit ();
			float max_distance = 100f;

			bool is_hit = Physics.Raycast (ray, out hit_info, max_distance); 


			if (is_hit) {
				if (hit_info.transform.name == hit_target.name) {
                    //TODO: ヒットした時の処理;

                    if (hit_info.transform.name == "Arrow9N")
                    {
                        GoToPoint10();
                    }
                    else if (hit_info.transform.name == "Arrow10N")
                    {
                        GoToPoint11();
                    }
                    else if (hit_info.transform.name == "Arrow11N")
                    {
                        GoToPoint12();
                    }
                    else if (hit_info.transform.name == "Arrow12N")
                    {
                        GoToPoint13();
                    }
                    else if (hit_info.transform.name == "Arrow13N")
                    {
                        GoToPoint14();
                    }
                    else if (hit_info.transform.name == "Arrow14N")
                    {
                        GoToPoint15();
                    }
                    else if (hit_info.transform.name == "Arrow14R")
                    {
                        GoToTateana();
                    }
                    else if (hit_info.transform.name == "Arrow15N")
                    {
                        GoToPoint16();
                    }
                    else if (hit_info.transform.name == "Arrow16N")
                    {
                        GoToPoint17();
                    }
                    else if (hit_info.transform.name == "Arrow17N")
                    {
                        GoToPoint19();
                    }
                    else if (hit_info.transform.name == "Arrow19N")
                    {
                        GoToPoint26();
                    }
                    else if (hit_info.transform.name == "Arrow26N")
                    {
                        GoToPoint28();
                    }
                    else if (hit_info.transform.name == "Arrow28N")
                    {
                        GoToPoint29();
                    }
                    else if (hit_info.transform.name == "Arrow28R")
                    {
                        GoToPoint27();
                    }
                    else if (hit_info.transform.name == "Arrow29B")
                    {
                        GoToPoint28();
                    }
                    else if (hit_info.transform.name == "Arrow28B")
                    {
                        GoToPoint26();
                    }
                    else if (hit_info.transform.name == "Arrow27B")
                    {
                        GoToPoint28();
                    }
                    else if (hit_info.transform.name == "Arrow26B")
                    {
                        GoToPoint19();
                    }
                    else if (hit_info.transform.name == "Arrow19B")
                    {
                        GoToPoint17();
                    }
                    else if (hit_info.transform.name == "Arrow17B")
                    {
                        GoToPoint16();
                    }
                    else if (hit_info.transform.name == "Arrow16B")
                    {
                        GoToPoint15();
                    }
                    else if (hit_info.transform.name == "Arrow15B")
                    {
                        GoToPoint14();
                    }
                    else if (hit_info.transform.name == "Arrow14B")
                    {
                        GoToPoint13();
                    }
                    else if (hit_info.transform.name == "Arrow13B")
                    {
                        GoToPoint12();
                    }
                    else if (hit_info.transform.name == "Arrow12B")
                    {
                        GoToPoint11();
                    }
                    else if (hit_info.transform.name == "Arrow11B")
                    {
                        GoToPoint10();
                    }
                    else if (hit_info.transform.name == "Arrow10B")
                    {
                        GoToPoint9();
                    }
                    else if (hit_info.transform.name == "Arrowtateana")
                    {
                        GoToPoint14();
                    }
                }
			}
		}
	}

    private void GoToPoint9()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //ArrowにもQタグをつけているのでPointClickのおかげでリセットされる
        pc.Point9();
    }

    private void GoToPoint10(){
		PointClick pc = Button.GetComponent<PointClick>();	
		pc.Point10();
	}

	private void GoToPoint11(){
		PointClick pc = Button.GetComponent<PointClick>();
		pc.Point11();
	}

	private void GoToPoint12(){
		PointClick pc = Button.GetComponent<PointClick>();
		pc.Point12();
	}

	private void GoToPoint13(){
		PointClick pc = Button.GetComponent<PointClick>();
		pc.Point13();
	}

	private void GoToPoint14(){
		PointClick pc = Button.GetComponent<PointClick>();
		pc.Point14();
	}

	private void GoToPoint15(){
		PointClick pc = Button.GetComponent<PointClick>();
		pc.Point15();
	}
    private void GoToPoint16()
    {
        PointClick pc = Button.GetComponent<PointClick>();
        pc.Point16();
    }

    private void GoToPoint17()
    {
        PointClick pc = Button.GetComponent<PointClick>();
        pc.Point17();
    }

    private void GoToPoint19(){
		PointClick pc = Button.GetComponent<PointClick>();
        pc.Point19();
	}

	private void GoToPoint26(){
		PointClick pc = Button.GetComponent<PointClick>();
        pc.Point26();
	}

    private void GoToPoint27()
    {
        PointClick pc = Button.GetComponent<PointClick>();
        pc.Point27();
    }


    private void GoToPoint28(){
		PointClick pc = Button.GetComponent<PointClick>();
		pc.Point28();
	}

	private void GoToPoint29(){
		PointClick pc = Button.GetComponent<PointClick>();
		pc.Point29();
	}
    private void GoToTateana()
    {
        PointClick pc = Button.GetComponent<PointClick>();
        pc.Tateana();
    }


}
