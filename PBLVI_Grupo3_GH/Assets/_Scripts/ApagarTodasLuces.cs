using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTodasLuces : MonoBehaviour
{
    public Material light;
    public MeshRenderer[] fire;
    public Light[] lights;
    public EncenderAntorcha[] inputBool;
    public Color ColorInicial;

    public void TurnOffAll()
    {
            //light.color = Color.red;
        light.SetColor("_EmissionColor", Color.red);
        //light.enabled = true;

        StartCoroutine(Espera());
    }

    public void ResetAllLights()
    {
        light.SetColor("_EmissionColor", ColorInicial);

        //Renderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (Renderer r in fire)
            r.enabled = false;

        foreach (Light l in lights)
            l.enabled = false;
        /*foreach (Material light in lights)
        {
            light.color = ColorInicial;
            //light.enabled = false;
        }*/

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
