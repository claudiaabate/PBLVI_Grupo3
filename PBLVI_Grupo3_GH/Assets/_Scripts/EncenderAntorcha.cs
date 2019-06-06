using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class EncenderAntorcha : MonoBehaviour
{
    AudioSource audioData;
    public AudioClip fire;

    public bool on = false;
    public bool incorrecta = false;
    public GameObject ui;

    //private Light antorcha;
    //private Renderer fuego;

    public ApagarTodasLuces ControladoraLlums;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        //antorcha = GetComponent<Light>();

        //Renderer fuego = this.GetComponent<MeshRenderer>();

        Renderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (Renderer r in rs)
            r.enabled = false;

        Light[] ls = GetComponentsInChildren<Light>();
        foreach (Light l in ls)
            l.enabled = false;

        on = false;
        //antorcha.enabled = false;

        //gameObject.GetComponent<Renderer>().enabled = false;

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


        if (Input.GetKeyDown(KeyCode.T) && !on && !incorrecta)
        {
            audioData.PlayOneShot(fire);
            TurnOn();
            //Debug.Log("EL objeto" + gameObject.name + "Tiene la booleana en: " + incorrecta + " por lo tanto  esta esta bien");
        }

        else if (Input.GetKeyDown(KeyCode.T) && !on && incorrecta)
        {
            RespuestaIncorrecta();

            //Debug.Log("EL objeto" + gameObject.name + "Tiene la booleana en: " + incorrecta + " por lo tanto  esta esta mal");
            //plyr.tag == "Player" && 
        }

        else if (Input.GetKeyDown(KeyCode.T) && on)
        {
            TurnOff();
        }
    }

    void TurnOn()
    {
        //antorcha.enabled = !antorcha.enabled;
        //gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;

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
        //gameObject.GetComponent<Renderer>().enabled = false;

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

        StartCoroutine(Waitt());
        Renderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (Renderer r in rs)
            r.enabled = !r.enabled;

        ControladoraLlums.TurnOffAll();

        /*foreach (Renderer r in rs)
            r.enabled = false;*/
    }

    IEnumerator Waitt()
    {
        yield return new WaitForSeconds(2f);
        Renderer[] rs = GetComponentsInChildren<MeshRenderer>();
        foreach (Renderer r in rs)
            r.enabled = false;
    }
}