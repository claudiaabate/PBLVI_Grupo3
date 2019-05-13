using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemas : Inventario
{
    public GameObject _gemaRa;
   // public GameObject _gemaHorus;
    public GameObject _gemaBastet;



    public GameObject _textGemas;

    public bool enter = true;
    public bool stay = true;


    void Start()
    {
       _gemaRa.SetActive(false);
        //_gemaHorus.SetActive(false);
       _gemaBastet.SetActive(false);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            _textGemas.SetActive(true);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _textGemas.SetActive(false);

            _IgemaRa.SetActive(true);

            _gemaRa.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.B))
        {
            _textGemas.SetActive(false);

            _IgemaBastet.SetActive(true);

            _gemaBastet.SetActive(false);
        }
    }
}
