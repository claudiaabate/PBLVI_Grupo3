using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiezaPuzzleBastet : Gemas
{
    public GameObject _pieza;
    public GameObject _estatuta;
    public GameObject _esconditeBastet;
    public GameObject _estatuaSin;

    public GameObject _textPieza;

    private Animator _animatorGBastet;

    //public GameObject camera_principal;
    public GameObject camera_gemaBastet;

    public GameObject Person;

    public GameObject TriggerLastPuzzle;

    void Start()
    {
        _estatuta.SetActive(false);
        _textPieza.SetActive(false);

        _animatorGBastet = _esconditeBastet.GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (enter)
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
            _animatorGBastet.SetBool("Out", true);
            TriggerLastPuzzle.SetActive(true);
            /*camera_principal.gameObject.SetActive(false);
            camera_gemaBastet.gameObject.SetActive(true);
            Person.gameObject.SetActive(false);*/
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
