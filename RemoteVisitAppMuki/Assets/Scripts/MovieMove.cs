using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovieMove : MonoBehaviour {

    //素材たち
    public GameObject Map;
    public GameObject Vector1;
    public GameObject Vector2;
    public GameObject Vector3;
    public GameObject Vector4;
    public GameObject Vector5;
    public GameObject Vector6;
    public GameObject Vector7;
    public GameObject Vector8;
    public GameObject BackButton;
    //点滅の間隔
    public float IntervalSec = 0.5f;

    //コピぺ
    //VideoPlayerコンポーネント
    public VideoPlayer mPlayer;

	void Start () 
    {
        //コルーチンの開始
        StartCoroutine("Move");
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public IEnumerator Move()
    {

        //戻るボタンを表示
        BackButton.SetActive(true);
     

        //矢印1の点滅
        Vector1.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector1.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector1.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector1.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector1.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector1.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(9f);
        mPlayer.Pause();

        //マップの再配置
        Map.SetActive(true);
        //矢印2の点滅
        Vector2.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector2.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector2.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector2.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector2.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector2.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(31f);
        mPlayer.Pause();

        //マップの再配置
        Map.SetActive(true);
        //矢印3の点滅
        Vector3.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector3.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector3.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector3.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector3.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector3.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(18f);
        mPlayer.Pause();

        //マップの再配置
        Map.SetActive(true);
        //矢印4の点滅
        Vector4.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector4.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector4.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector4.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector4.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector4.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(33f);
        mPlayer.Pause();

        //マップの再配置
        Map.SetActive(true);
        //矢印5の点滅
        Vector5.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector5.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector5.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector5.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector5.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector5.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(13f);
        mPlayer.Pause();

        //マップの再配置
        Map.SetActive(true);
        //矢印6の点滅
        Vector6.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector6.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector6.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector6.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector6.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector6.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(34f);
        mPlayer.Pause();

        //マップの再配置
        Map.SetActive(true);
        //矢印7の点滅
        Vector7.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector7.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector7.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector7.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector7.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector7.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(19f);
        mPlayer.Pause();

        //マップの再配置
        Map.SetActive(true);
        //矢印8の点滅
        Vector8.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector8.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector8.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector8.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        Vector8.SetActive(true);
        yield return new WaitForSeconds(IntervalSec);
        Vector8.SetActive(false);
        yield return new WaitForSeconds(IntervalSec);
        //マップの消去
        Map.SetActive(false);

        //動画の再生
        mPlayer.Play();
        yield return new WaitForSeconds(31f);
        mPlayer.Pause();

    }

    public void BackTitle()
    {
        Debug.Log("シーン移動");
		SceneManager.LoadScene("TitleScene");
    }
}
