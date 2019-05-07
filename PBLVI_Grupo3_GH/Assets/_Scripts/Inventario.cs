using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public GameObject _inventario;

    public GameObject _ImonedaRa;
    public GameObject _ImonedaHorus;
    public GameObject _ImonedaBastet;

    public GameObject _textMonedas;

    public GameObject _gemaRa;
    public GameObject _gemaHorus;
    public GameObject _gemaBastet;


    void Start()
    {
        _inventario.SetActive(false);

        _ImonedaRa.SetActive(false);
        _ImonedaHorus.SetActive(false);
        _ImonedaBastet.SetActive(false);

        _gemaRa.SetActive(false);
        _gemaHorus.SetActive(false);
        _gemaBastet.SetActive(false);

    }


    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            _inventario.SetActive(!_inventario.activeSelf);

            _textMonedas.SetActive(false);
            
        }
    }


}
