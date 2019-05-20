using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGuide : MonoBehaviour
{
    public GameObject hit_target;
    public GameObject Button;//ButtonについてるPointClickの関数を利用するため

    public AudioClip Voice9;
    public AudioClip Voice10;
    public AudioClip Voice12;
    public AudioClip Voice14;
    public AudioClip Voice16;
    public AudioClip Voice17;
    public AudioClip Voice27;
    public AudioClip Voice28;
    public AudioClip Voice29;
    public AudioClip VoiceTateana;

    private AudioSource Voice;

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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit_info = new RaycastHit();
            float max_distance = 100f;

            bool is_hit = Physics.Raycast(ray, out hit_info, max_distance);


            if (is_hit)
            {
                if (hit_info.transform.name == hit_target.name)
                {
                    if (hit_info.transform.name == "Guide9")
                    {
                        GoToGuide9();

                    }
                    else if (hit_info.transform.name == "Guide10")
                    {
                        GoToGuide10();
                    }
                    else if (hit_info.transform.name == "Guide12")
                    {
                        GoToGuide12();
                    }
                    else if (hit_info.transform.name == "Guide14")
                    {
                        GoToGuide14();
                    }
                    else if (hit_info.transform.name == "Guide16")
                    {
                        GoToGuide16();
                    }
                    else if (hit_info.transform.name == "Guide17")
                    {
                        GoToGuide17();
                    }
                    else if (hit_info.transform.name == "Guide27")
                    {
                        GoToGuide27();
                    }
                    else if (hit_info.transform.name == "Guide28")
                    {
                        GoToGuide28();
                    }
                    else if (hit_info.transform.name == "Guide29")
                    {
                        GoToGuide29();
                    }
                    else if (hit_info.transform.name == "GuideTateana")
                    {
                        GoToGuideTateana();
                    }
                }
            }
        }
    }
    private void GoToGuide9()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice9;
        Voice.Play();

    }
    private void GoToGuide10()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice10;
        Voice.Play();

    }
    private void GoToGuide12()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice12;
        Voice.Play();

    }
    private void GoToGuide14()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice14;
        Voice.Play();

    }
    private void GoToGuide16()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice16;
        Voice.Play();

    }
    private void GoToGuide17()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice17;
        Voice.Play();

    }
    private void GoToGuide27()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice27;
        Voice.Play();

    }
    private void GoToGuide28()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice28;
        Voice.Play();

    }
    private void GoToGuide29()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = Voice29;
        Voice.Play();

    }
    private void GoToGuideTateana()
    {
        PointClick pc = Button.GetComponent<PointClick>();  //GuideにもQタグをつけているのでPointClickのおかげでリセットされる
        Voice = gameObject.GetComponent<AudioSource>();
        Voice.clip = VoiceTateana;
        Voice.Play();

    }
}
