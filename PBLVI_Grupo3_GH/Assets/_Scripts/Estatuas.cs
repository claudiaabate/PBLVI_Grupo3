using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estatuas : MonoBehaviour
{
    public GameObject _estatuaSin;

    private Animator _animator1;
    private Animator _animator2;

    public GameObject pared1;
    public GameObject pared2;

    public GameObject _textEstatua;


    void Start()
    {
        _textEstatua.SetActive(false);

        _animator1 = pared1.GetComponent<Animator>();
        _animator2 = pared2.GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _textEstatua.SetActive(true);
        }

        
    }


    private void OnTriggerExit(Collider other)
    {
            _textEstatua.SetActive(false);

            pared1.SetActive(true);
            pared2.SetActive(true);

            _animator1.SetBool("Cierre1", true);
            _animator2.SetBool("Cierre2", true);
    }

}
