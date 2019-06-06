using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiezaPuzzleBastet : Gemas
{
    public GameObject _pieza;
    public GameObject _estatuta;
    public GameObject _esconditeBastet;
    public GameObject _estatuaSin;

    public GameObject pared1;
    public GameObject pared2;

    public GameObject _textPieza;

    private Animator _animatorGBastet;

    //public GameObject camera_principal;
    public GameObject camera_gemaBastet;

    public GameObject Person;

    public GameObject TriggerLastPuzzle;

    public GameObject sound;
    AudioSource audioData;
    public AudioClip escondite;

    void Start()
    {
        _estatuta.SetActive(false);
        _textPieza.SetActive(false);

        _animatorGBastet = _esconditeBastet.GetComponent<Animator>();
        audioData = sound.GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _textPieza.SetActive(true);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(WaitTime3());
            _textPieza.SetActive(false);
            _estatuaSin.SetActive(false);
            _estatuta.SetActive(true);

            pared1.transform.position = new Vector3(-1.87f, 0f, -0.14f);
            pared2.transform.position = new Vector3(-0.91f, 0f, -0.14f);
            pared1.SetActive(false);
            pared2.SetActive(false);

            audioData.PlayOneShot(escondite);

            _animatorGBastet.SetBool("Out", true);
            TriggerLastPuzzle.SetActive(true);
            /*camera_principal.gameObject.SetActive(false);
            camera_gemaBastet.gameObject.SetActive(true);
            Person.gameObject.SetActive(false);*/
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _textPieza.SetActive(false);
        }
    }

    IEnumerator WaitTime3()
    {
        camera_principal.gameObject.SetActive(false);
        camera_gemaBastet.gameObject.SetActive(true);
        Person.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        camera_principal.gameObject.SetActive(true);
        camera_gemaBastet.gameObject.SetActive(false);
        Person.gameObject.SetActive(true);
        _pieza.SetActive(false);
    }
}
