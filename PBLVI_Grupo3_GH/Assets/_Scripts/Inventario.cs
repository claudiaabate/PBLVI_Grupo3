using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public GameObject _inventario;
    public GameObject _monedaRa;
    public GameObject _monedaHorus;
    public GameObject _monedaBastet;

    public GameObject _text;

    public Text _textContadorRa;
    public int _monedasRa = 0;



    void Start()
    {
        _inventario.SetActive(false);
        _monedaRa.SetActive(false);
        _monedaHorus.SetActive(false);
        _monedaBastet.SetActive(false);
        
    }


    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            _inventario.SetActive(!_inventario.activeSelf);
            _text.SetActive(false)
;       }
    }


}
