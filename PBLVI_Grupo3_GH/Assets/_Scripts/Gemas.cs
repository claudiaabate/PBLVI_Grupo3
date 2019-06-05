using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Gemas : Inventario
{
    AudioSource audioData;
    public AudioClip opendoor;

    public GameObject _gemaRa;
    public GameObject _gemaHorus;
    public GameObject _gemaBastet;

    public GameObject _puertaHorus;
    private Animator _animatorHorus;

    public GameObject _puertaBastet;
    private Animator _animatorBastet;


    public GameObject _textGemas;
    public GameObject textGeneral;


    public bool enter = true;
    public bool stay = true;

    public GameObject camera_doorHorus;
    public GameObject camera_doorBastet;
    public GameObject camera_principal;

    /*public GameObject camera_principal;
    public GameObject camera_gemaRa;
    public GameObject camera_gemaHorus;
    public GameObject camera_gemaBastet;

    public GameObject Person;*/


    void Start()
    {
        _textGemas.SetActive(false);

        _animatorHorus = _puertaHorus.GetComponent<Animator>();
        _animatorBastet = _puertaBastet.GetComponent<Animator>();

        audioData = GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("COLLISION DETECTADA");
        if (enter)
        {
            //Debug.Log("ENTRA CONDICION");
            _textGemas.SetActive(true);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _IgemaRa.SetActive(true);

            _gemaRa.SetActive(false);

            _textGemas.SetActive(false);

            textGeneral.SetActive(true);
            StartCoroutine(WaitTimeText());

            StartCoroutine(WaitTimeHorus());

            _animatorHorus.SetBool("ShouldOpen", true);
            audioData.PlayOneShot(opendoor);

            /*camera_principal.gameObject.SetActive(true);
            camera_gemaRa.gameObject.SetActive(false);
            Person.gameObject.SetActive(true);*/
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            _textGemas.SetActive(false);

            _IgemaHorus.SetActive(true);

            StartCoroutine(WaitTimeBastet());

            _animatorBastet.SetBool("ShouldOpen", true);
            audioData.PlayOneShot(opendoor);

            /*camera_principal.gameObject.SetActive(true);
            camera_gemaHorus.gameObject.SetActive(false);
            Person.gameObject.SetActive(true);*/
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            _textGemas.SetActive(false);

            _IgemaBastet.SetActive(true);

            _gemaBastet.SetActive(false);
            /*camera_principal.gameObject.SetActive(true);
            camera_gemaBastet.gameObject.SetActive(false);
            Person.gameObject.SetActive(true);*/
        }
    }

    IEnumerator WaitTimeHorus()
    {
        camera_principal.gameObject.SetActive(false);
        camera_doorHorus.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        camera_principal.gameObject.SetActive(true);
        camera_doorHorus.gameObject.SetActive(false);
    }

    IEnumerator WaitTimeBastet()
    {
        camera_principal.gameObject.SetActive(false);
        camera_doorBastet.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        camera_principal.gameObject.SetActive(true);
        camera_doorBastet.gameObject.SetActive(false);
        _gemaHorus.SetActive(false);
    }

    IEnumerator WaitTimeText()
    {
        yield return new WaitForSeconds(1f);
        textGeneral.SetActive(false);

    }
}
