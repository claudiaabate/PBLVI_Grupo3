using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolucionPuzleUno : Gemas
{
    public EncenderAntorcha Vatra_01;
    public EncenderAntorcha Vatra_02;
    public EncenderAntorcha Vatra_03;
    public EncenderAntorcha Vatra_04;
    public EncenderAntorcha Vatra_05;
    public EncenderAntorcha Vatra_06;
    public EncenderAntorcha Vatra_07;
    public EncenderAntorcha Vatra_08;
    

    //public Material Material_WIN;
    //public Material Material_LOSE;
    private Renderer _renderer;
    public Animator anim;

    public GameObject camera_principal;
    public GameObject camera_gemaRa;

    public GameObject Person;

    void Start()
    {
        _renderer = transform.GetComponent<Renderer>();
        anim.GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            CheckTheResult();
        }
    }

    void CheckTheResult()
    {
        if (Vatra_01.on == true && Vatra_02.on == false && Vatra_03.on == true && Vatra_04.on == true && Vatra_05.on == false && Vatra_06.on == true && Vatra_07.on == false && Vatra_08.on == true)
        
        {
            //Debug.Log("ES CORRECTE");
            _gemaRa.SetActive(true);
            anim.Play("EsconditeRa");

            StartCoroutine(WaitTime());
            //_renderer.material = Material_WIN;

        }

        else
        {
            //Debug.Log("ES INCORRECTE");
            //_renderer.material = Material_LOSE;
        }
    }

    IEnumerator WaitTime()
    {
        camera_principal.gameObject.SetActive(false);
        camera_gemaRa.gameObject.SetActive(true);
        Person.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        camera_principal.gameObject.SetActive(true);
        camera_gemaRa.gameObject.SetActive(false);
        Person.gameObject.SetActive(true);
    }

}
