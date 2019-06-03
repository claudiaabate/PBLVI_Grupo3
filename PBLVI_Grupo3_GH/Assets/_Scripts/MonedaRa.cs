﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedaRa : MonoBehaviour
{ 
    public GameObject _monedaRa;
    public GameObject _ImonedaRa;

    public GameObject _textMonedas;
    public GameObject trigger;


    void Start()
    {
        _ImonedaRa.SetActive(false);
        _textMonedas.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        _monedaRa.SetActive(false);

        _textMonedas.SetActive(true);
        StartCoroutine(WaitTime());

        _ImonedaRa.SetActive(true);
       
    }


    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(4f);
        _textMonedas.SetActive(false);
    }
}
