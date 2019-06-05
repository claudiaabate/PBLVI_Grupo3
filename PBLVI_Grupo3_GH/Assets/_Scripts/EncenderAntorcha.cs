using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderAntorcha : MonoBehaviour
{

    public bool on = false;
    public bool incorrecta = false;
    public GameObject ui;

    //private Light antorcha;
    private Renderer fuego;

    public ApagarTodasLuces ControladoraLlums;

    void Start()
    {
        //antorcha = GetComponent<Light>();

        fuego = GetComponent<MeshRenderer>();

        Renderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (Renderer r in rs)
            r.enabled = false;

        Light[] ls = GetComponentsInChildren<Light>();
        foreach (Light l in ls)
            l.enabled = false;

        on = false;
        //antorcha.enabled = false;

        fuego.enabled = false;

        //Debug.Log("EL objeto" + gameObject.name + "Tiene la booleana en: " + incorrecta);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ui.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ui.SetActive(false);

        }
    }

    private void OnTriggerStay(Collider plyr)
    {


        if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.T) && !on && !incorrecta)
        {
            TurnOn();
            //Debug.Log("EL objeto" + gameObject.name + "Tiene la booleana en: " + incorrecta + " por lo tanto  esta esta bien");
        }

        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.T) && !on && incorrecta)
        {
            RespuestaIncorrecta();

            //Debug.Log("EL objeto" + gameObject.name + "Tiene la booleana en: " + incorrecta + " por lo tanto  esta esta mal");

        }

        else if (plyr.tag == "Player" && Input.GetKeyDown(KeyCode.T) && on)
        {
            TurnOff();
        }
    }

    void TurnOn()
    {
        //antorcha.enabled = !antorcha.enabled;

        fuego.enabled = !fuego.enabled;

        Renderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (Renderer r in rs)
            r.enabled = !r.enabled;

        Light[] ls = GetComponentsInChildren<Light>();
        foreach (Light l in ls)
            l.enabled = !l.enabled;


        on = true;
    }

    void TurnOff()
    {
        //antorcha.enabled = false;

        fuego.enabled = false;

        Renderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (Renderer r in rs)
            r.enabled = false;

        Light[] ls = GetComponentsInChildren<Light>();
        foreach (Light l in ls)
            l.enabled = false;

        on = false;
    }

    void RespuestaIncorrecta()
    {
        //Debug.Log("HAS COMETIDO UN ERROR");

        ControladoraLlums.TurnOffAll();
    }


}