using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedaRa : Inventario
{
    public int _monedas = 0;

    public GameObject _monedaRa;
    public GameObject _monedaHorus;
    public GameObject _monedaBastet;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;

    public GameObject _text;

    void Start()
    {
        _text.SetActive(false);
        _textMonedas.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            _text.SetActive(true);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _text.SetActive(false);

            _textMonedas.SetActive(true);
            _ImonedaRa.SetActive(true);

            _monedas = _monedas + 1;
            _monedaRa.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            _text.SetActive(false);

            _textMonedas.SetActive(true);
            _ImonedaHorus.SetActive(true);

            _monedas = _monedas + 1;
            _monedaHorus.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            _text.SetActive(false);

            _textMonedas.SetActive(true);
            _ImonedaBastet.SetActive(true);

            _monedas = _monedas + 1;
            _monedaBastet.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            _text.SetActive(false);
        }
    }
}
