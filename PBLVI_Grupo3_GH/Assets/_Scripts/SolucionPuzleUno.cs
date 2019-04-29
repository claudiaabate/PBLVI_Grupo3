using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolucionPuzleUno : MonoBehaviour
{
    public EncenderAntorcha Vatra_01;
    public EncenderAntorcha Vatra_02;
    public EncenderAntorcha Vatra_03;
    public EncenderAntorcha Vatra_04;
    public EncenderAntorcha Vatra_05;
    public EncenderAntorcha Vatra_06;
    public EncenderAntorcha Vatra_07;
    public EncenderAntorcha Vatra_08;
    public EncenderAntorcha Vatra_09;
    public EncenderAntorcha Vatra_10;
    public EncenderAntorcha Vatra_11;
    public EncenderAntorcha Vatra_12;

    public Material Material_WIN;
    public Material Material_LOSE;
    private Renderer _renderer;

    void Start()
    {
        _renderer = transform.GetComponent<Renderer>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckTheResult();
        }
    }

    void CheckTheResult()
    {
        if (Vatra_01.on == false && Vatra_02.on == true && Vatra_03.on == false && Vatra_04.on == true && Vatra_05.on == true && Vatra_06.on == false && Vatra_07.on == true && Vatra_08.on == false && Vatra_09.on == true && Vatra_10.on == true && Vatra_11.on == false && Vatra_12.on == true)
        
        {
            Debug.Log("ES CORRECTE");
            _renderer.material = Material_WIN;

        }

        else
        {
            Debug.Log("ES INCORRECTE");
            _renderer.material = Material_LOSE;
        }
    }
}
