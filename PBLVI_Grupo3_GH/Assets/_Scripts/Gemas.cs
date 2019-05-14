using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemas : Inventario
{
    public GameObject _gemaRa;
    public GameObject _gemaHorus;
    public GameObject _gemaBastet;

    public GameObject _puertaHorus;
    private Animator _animatorHorus;

    public GameObject _puertaBastet;
    private Animator _animatorBastet;


    public GameObject _textGemas;

    public bool enter = true;
    public bool stay = true;


    void Start()
    {
       _textGemas.SetActive(false);
       _gemaRa.SetActive(true);
       _gemaHorus.SetActive(true);
       _gemaBastet.SetActive(true);

        _animatorHorus = _puertaHorus.GetComponent<Animator>();
        _animatorBastet = _puertaBastet.GetComponent<Animator>();
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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _textGemas.SetActive(false);

            _IgemaRa.SetActive(true);

            _gemaRa.SetActive(false);

            _animatorHorus.SetBool("ShouldOpen", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _textGemas.SetActive(false);

            _IgemaHorus.SetActive(true);

            _gemaHorus.SetActive(false);

            _animatorBastet.SetBool("ShouldOpen", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _textGemas.SetActive(false);

            _IgemaBastet.SetActive(true);

            _gemaBastet.SetActive(false);
        }
    }
}
