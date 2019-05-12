using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTodasLuces : MonoBehaviour
{

    public Light[] lights;
    public Color ColorInicial;

    public void TurnOffAll()

    {
        
        foreach (Light light in lights)
        {


            light.color = Color.red;
            light.enabled = true;



        }

        StartCoroutine(Espera());

        IEnumerator Espera()
        {
            print(Time.time);
            yield return new WaitForSeconds(5);
            print(Time.time);
        }




        
    }

    public void ResetAllLights()
    {
        foreach (Light light in lights)
        {

            light.color = ColorInicial;
            light.enabled = false;



        }
    }
    
    
   
}
