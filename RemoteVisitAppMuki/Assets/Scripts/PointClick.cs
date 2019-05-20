using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointClick : MonoBehaviour {
    //ミニマップの画像(要追加)
    public Sprite img9;
	public Sprite img10;
	public Sprite img11;
	public Sprite img12;
	public Sprite img13;
    public Sprite img14;
    public Sprite img15;
    public Sprite img16;
    public Sprite img17;
    public Sprite img19;
    public Sprite img26;
    public Sprite img28;
    public Sprite img29;
    public Sprite img27;

    public Image img;

	//キャンバスの定義
	public GameObject MapCanvas;
	public GameObject MainCanvas;

	//球のマテリアル定義
	public Material sphere;

    //球に貼り付けるテクスチャの定義(要追加)
    public Texture tx9;
	public Texture tx10;
	public Texture tx11;
	public Texture tx12;
	public Texture tx13;
    public Texture tx14;
    public Texture tx15;
    public Texture tx16;
    public Texture tx17;
    public Texture tx19;
    public Texture tx26;
    public Texture tx27;
    public Texture tx28;
    public Texture tx29;
    public Texture tateana;

    //question達(要追加)Questionの数字は見学地点の数字を使う
    public GameObject Question2;
	public GameObject Question3;
	public GameObject Question4dash;
	public GameObject Question5;
	public GameObject Question6;
	public GameObject Question71;
	public GameObject Question72;
	public GameObject Question8;
	public GameObject Question9;
	public GameObject Question101;
	public GameObject Question102;
	public GameObject Question121;
	public GameObject Question122;

    //移動矢印
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
    public GameObject Arrow27B;
    public GameObject Arrow28R;
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

    public GameObject Guide9;
    public GameObject Guide10;
    public GameObject Guide12;
    public GameObject Guide14;
    public GameObject Guide16;
    public GameObject Guide17;
    public GameObject Guide27;
    public GameObject Guide28;
    public GameObject Guide29;
    public GameObject GuideTateana;


    // Use this for initialization
    void Start () 
	{
        
		//img = this.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

    //各地点をクリックした時の動作なので要追加
    public void Point9()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }
        //Question9.SetActive(true);    //この地点のQuestionを設置
       /* GameObject[] Guides = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Guide in Guides)
        {
            Guide.SetActive(false);
        }*/
        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img9; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx9);    //背景の切り替え
        Arrow9N.SetActive(true);
        Guide9.SetActive(true);
    }

    public void Point10 ()
	{
		//Questionのリセット
		GameObject[] Questions =GameObject.FindGameObjectsWithTag("Q");
		foreach (GameObject Question in Questions)
		{
			Question.SetActive (false);
		}
        //Question10.SetActive (true);	//この地点のQuestionを設置
 
        ChangeCanvas();	//キャンバスの切り替え
		img.sprite = img10;	//ミニマップの切り替え
		sphere.SetTexture("_MainTex",tx10);	//背景の切り替え
		Arrow10N.SetActive (true);
        Arrow10B.SetActive(true);
        Guide10.SetActive(true);
	}

	public void Point11 ()
	{
		//Questionのリセット
		GameObject[] Questions =GameObject.FindGameObjectsWithTag("Q");
		foreach (GameObject Question in Questions)
		{
			Question.SetActive (false);
		}

        ChangeCanvas();	//キャンバスの切り替え
		img.sprite = img11;	//ミニマップの切り替え
		sphere.SetTexture("_MainTex",tx11);	//背景の切り替え
		Arrow11N.SetActive (true);
		Arrow11B.SetActive (true);
	}

	public void Point12 ()
	{
		//Questionのリセット
		GameObject[] Questions =GameObject.FindGameObjectsWithTag("Q");
		foreach (GameObject Question in Questions)
		{
			Question.SetActive (false);
		}

        ChangeCanvas();	//キャンバスの切り替え
		img.sprite = img12;	//ミニマップの切り替え
		sphere.SetTexture("_MainTex",tx12);	//背景の切り替え
		Arrow12N.SetActive (true);
		Arrow12B.SetActive (true);
        Guide12.SetActive(true);
	}

    public void Point13()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img13; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx13);    //背景の切り替え
        Arrow13N.SetActive(true);
        Arrow13B.SetActive(true);
    }

    public void Point14 ()
	{
		//Questionのリセット
		GameObject[] Questions =GameObject.FindGameObjectsWithTag("Q");
		foreach (GameObject Question in Questions)
		{
			Question.SetActive (false);
		}
 
        ChangeCanvas();	//キャンバスの切り替え
		img.sprite = img14;	//ミニマップの切り替え
		sphere.SetTexture("_MainTex",tx14);	//背景の切り替え
        Arrow14N.SetActive(true);
		Arrow14B.SetActive (true);
        Arrow14R.SetActive(true);
        Guide14.SetActive(true);
	}

    public void Point15()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }
 
        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img15; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx15);    //背景の切り替え
        Arrow15N.SetActive(true);
        Arrow15B.SetActive(true);
    }

    public void Point16()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img16; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx16);    //背景の切り替え
        Arrow16N.SetActive(true);
        Arrow16B.SetActive(true);
        Guide16.SetActive(true);
    }
    public void Point17()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img16; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx17);    //背景の切り替え
        Arrow17N.SetActive(true);
        Arrow17B.SetActive(true);
        Guide17.SetActive(true);
    }


    public void Point19()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img19; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx19);    //背景の切り替え
        Arrow19N.SetActive(true);
        Arrow19B.SetActive(true);
    }

    public void Point26()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img26; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx26);    //背景の切り替え
        Arrow26N.SetActive(true);
        Arrow26B.SetActive(true);

    }
    public void Point27()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img27; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx27);    //背景の切り替え
        Arrow27B.SetActive(true);
        Guide27.SetActive(true);
    }

    public void Point28()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img28; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx28);    //背景の切り替え
        Arrow28N.SetActive(true);
        Arrow28B.SetActive(true);
        Arrow28R.SetActive(true);
        Guide28.SetActive(true);
    }

    public void Point29()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }
 

        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img29; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tx29);    //背景の切り替え
        Arrow29B.SetActive(true);
        Guide29.SetActive(true);
    }
    public void Tateana()
    {
        //Questionのリセット
        GameObject[] Questions = GameObject.FindGameObjectsWithTag("Q");
        foreach (GameObject Question in Questions)
        {
            Question.SetActive(false);
        }
  
        ChangeCanvas(); //キャンバスの切り替え
        img.sprite = img14; //ミニマップの切り替え
        sphere.SetTexture("_MainTex", tateana);    //背景の切り替え
        Arrowtateana.SetActive(true);
        GuideTateana.SetActive(true);
    }

    //ミニマップに戻るときのメソッド
    public void MiniMapTouch ()
	{
		MapCanvas.SetActive(true);
		MainCanvas.SetActive(false);
	}

	//キャンバスの切り替え
	private void ChangeCanvas(){
		MapCanvas.SetActive (false);
		MainCanvas.SetActive (true);
	}
}
