using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderAntorcha : MonoBehaviour
{
    
    public bool on = false;
    private Light antorcha;

    void Start()
    {
        antorcha = GetComponent<Light>();
    }

    private void OnTriggerStay(Collider plyr)
    {
        if(plyr.tag == "Player" && Input.GetKeyDown(KeyCode.E) && !on)
        {
            antorcha.enabled = !antorcha.enabled;
            on = true;
        }

        else if (plyr.tag=="Player" && Input.GetKeyDown(KeyCode.E) && on)
        {
            antorcha.enabled = false;
            on = false;
        }
    }


}
