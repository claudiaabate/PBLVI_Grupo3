using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTodasLuces : MonoBehaviour
{

    public Light[] lights;

    public void TurnOffAll()

    {

        foreach (Light light in lights)
        {
            
                
                light.enabled = false;
            
                
            
        }
    }
    
    
   
}
