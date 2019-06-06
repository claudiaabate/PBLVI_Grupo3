﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public GameObject _inventario;

    public GameObject _IgemaRa;
    public GameObject _IgemaHorus;
    public GameObject _IgemaBastet;

    public GameObject _ImonedaRa;
    public GameObject _ImonedaHorus;
    public GameObject _ImonedaBastet;

    public GameObject _textMonedas;
    public GameObject textGeneral;

    void Start()
    {
        _inventario.SetActive(false);

        _IgemaRa.SetActive(false);
        _IgemaHorus.SetActive(false);
        _IgemaBastet.SetActive(false);

    }


    void Update()

    {
        if (Input.GetKeyDown("i"))
        {
            _inventario.SetActive(true);
            textGeneral.SetActive(false);
            _textMonedas.SetActive(false);

        }
    }


    public void X()
    {
        _inventario.SetActive(false);
    }
}
