using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monedas : Inventario
{
    public GameObject _Ra;
    public GameObject _Horus;
    public GameObject _Bastet;

    

    void Start()
    {
        _text.SetActive(false);
    }



    void OnTriggerEnter(Collider other)
    {
        _text.SetActive(true);
        _monedaRa.SetActive(true);

        if (_Ra)
        {
            _monedasRa = _monedasRa + 1;
            _textContadorRa.text = _monedasRa.ToString();
        }

        _Ra.SetActive(false);
    }

    void Update()
    {

    }
}
