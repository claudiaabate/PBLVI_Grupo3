using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTodasLuces : MonoBehaviour
{
    //public Light[] lights;
    public GameObject[] fuego;
    public EncenderAntorcha[] inputBool;
    public Color ColorInicial;

    public void TurnOffAll()
    {
        Material fire = GetComponent<Renderer>().material;

        foreach (GameObject fuego in fuego)
        {
            fire.SetColor("_EmissionColor", Color.red);
            //light.enabled = true;
        }

        StartCoroutine(Espera());
    }

    public void ResetAllLights()
    {
        Material fire = GetComponent<Renderer>().material;

        foreach (GameObject fuego in fuego)
        {
            fire.SetColor("_EmissionColor", ColorInicial);
            //light.enabled = false;
        }

        for (int i = 0; i < inputBool.Length; i++)
        {
            inputBool[i].on = false;
        }
    }

    IEnumerator Espera()
    {
        yield return new WaitForSeconds(2f);
        ResetAllLights();
    }
}
