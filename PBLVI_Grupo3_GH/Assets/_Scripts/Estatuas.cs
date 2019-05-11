using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatuas : MonoBehaviour
{
    public GameObject _estatuaSin;
    public GameObject _estatua;

    private Animator _animator1;
    private Animator _animator2;

    public GameObject pared1;
    public GameObject pared2;

    public GameObject _textEstatua;

    public bool enter = true;
    public bool exit = true;

    void Start()
    {
        _estatua.SetActive(false);
        _textEstatua.SetActive(false);

        pared1.SetActive(false);
        pared2.SetActive(false);

        _animator1 = pared1.GetComponent<Animator>();
        _animator2 = pared2.GetComponent<Animator>();
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

            pared1.SetActive(true);
            pared2.SetActive(true);

            _animator1.SetBool("Cierre1", true);
            _animator2.SetBool("Cierre2", true);
        }

    }

}
