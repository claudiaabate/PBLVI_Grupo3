using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPared : MonoBehaviour
{
    public GameObject Char;

    public GameObject pared1;
    public GameObject pared2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pared")
        {
            Char.transform.position = new Vector3(-4.86f, 0.005f, 2.96f);
            pared1.transform.position = new Vector3(-1.87f, 0f, -0.14f);
            pared2.transform.position = new Vector3(-0.91f, 0f, -0.14f);
            pared1.SetActive(false);
            pared2.SetActive(false);
        }
    }
}
