using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatuas : MonoBehaviour
{
    public GameObject _estatuaSin;
    public GameObject _estatua;

    public GameObject _textEstatua;

    public bool enter = true;
    public bool exit = true;



    void Start()
    {
        _estatua.SetActive(false);
        _textEstatua.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            _textEstatua.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            _textEstatua.SetActive(false);
        }
    }

}
