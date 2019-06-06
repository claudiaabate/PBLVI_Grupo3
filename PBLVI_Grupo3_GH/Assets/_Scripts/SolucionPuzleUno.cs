using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolucionPuzleUno : MonoBehaviour
{
    public EncenderAntorcha Vatra_01;
    public EncenderAntorcha Vatra_02;
    public EncenderAntorcha Vatra_03;
    public EncenderAntorcha Vatra_04;
    public EncenderAntorcha Vatra_05;
    public EncenderAntorcha Vatra_06;
    public EncenderAntorcha Vatra_07;
    public EncenderAntorcha Vatra_08;

    public GameObject _gemaRa;

    public GameObject Material_WIN;

    private Renderer _renderer;
    public Animator anim;

    public GameObject camera_principal;
    public GameObject camera_gemaRa;

    public GameObject Person;

    public GameObject sound;
    AudioSource audioData;
    public AudioClip escondite;


    void Start()
    {
        _renderer = transform.GetComponent<Renderer>();
        anim.GetComponent<Animator>();
        _gemaRa.SetActive(false);

        audioData = sound.GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            CheckTheResult();
        }
    }

    void CheckTheResult()
    {
        if (Vatra_01.on == true && Vatra_02.on == false && Vatra_03.on == true && Vatra_04.on == true && Vatra_05.on == false && Vatra_06.on == true && Vatra_07.on == false && Vatra_08.on == true)
        
        {
            //Debug.Log("ES CORRECTE");
            _gemaRa.SetActive(true);
            anim.Play("EsconditeRa");
            audioData.PlayOneShot(escondite);

            StartCoroutine(WaitTime1());
            /*camera_principal.gameObject.SetActive(false);
            camera_gemaRa.gameObject.SetActive(true);
            Person.gameObject.SetActive(false);*/
            Material_WIN.SetActive(true);

        }

        else
        {
            //Debug.Log("ES INCORRECTE");
        }
    }

    IEnumerator WaitTime1()
    {
        camera_principal.gameObject.SetActive(false);
        camera_gemaRa.gameObject.SetActive(true);
        Person.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        camera_principal.gameObject.SetActive(true);
        camera_gemaRa.gameObject.SetActive(false);
        Person.gameObject.SetActive(true);
    }

}
