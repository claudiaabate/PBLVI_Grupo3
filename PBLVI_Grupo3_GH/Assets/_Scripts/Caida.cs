using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour
{
    public GameObject personaje;
    private Animator animator = null;

    void Start()
    {
        animator = personaje.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        //animator.SetFloat("blendSpeed", 2);
        personaje.GetComponent<RemyControler>().playerInteractuando = true;
    }

    private void OnTriggerExit(Collider other)
    {
        //animator.SetFloat("blendSpeed", 0);
        personaje.GetComponent<RemyControler>().playerInteractuando = false;
        GetComponent<Collider>().enabled = false;
    }
}
