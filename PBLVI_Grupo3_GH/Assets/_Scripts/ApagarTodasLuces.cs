using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTodasLuces : MonoBehaviour
{

    public Light[] lights;
    public EncenderAntorcha[] inputBool;
    public Color ColorInicial;

    public void TurnOffAll()

    {
        
        foreach (Light light in lights)
        {


            light.color = Color.red;
            light.enabled = true;



        }

        StartCoroutine(Espera());
        
        




        
    }

    public void ResetAllLights()
    {
        foreach (Light light in lights)
        {
            
            
            light.color = ColorInicial;
            light.enabled = false;



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
