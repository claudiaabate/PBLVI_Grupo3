using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderAntorcha : MonoBehaviour
{

    public bool on = false;
    public bool incorrecta = false;
    public GameObject ui;

    private Light antorcha;
    public ApagarTodasLuces ControladoraLlums;


    void Start()
    {
        antorcha = GetComponent<Light>();
        on = false;
        antorcha.enabled = false;
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
        antorcha.enabled = !antorcha.enabled;
        on = true;
    }

    void TurnOff()
    {
        antorcha.enabled = false;
        on = false;
    }

    void RespuestaIncorrecta()
    {
        //Debug.Log("HAS COMETIDO UN ERROR");

        ControladoraLlums.TurnOffAll();
    }


}