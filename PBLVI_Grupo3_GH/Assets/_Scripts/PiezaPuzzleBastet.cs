using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiezaPuzzleBastet : Gemas
{
    public GameObject _pieza;
    public GameObject _estatuta;

    public GameObject _estatuaSin;

    public GameObject _textPieza;


    void Start()
    {
        _estatuta.SetActive(false);
        _textPieza.SetActive(false); 
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
        if (Input.GetKeyDown(KeyCode.B))
        {
            _pieza.SetActive(false);
            _estatuaSin.SetActive(false);
            _estatuta.SetActive(true);
            _gemaBastet.SetActive(true);

        }

    }

}
