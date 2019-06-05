using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPared : MonoBehaviour
{
    public GameObject pared;
    public GameObject Char;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pared")
        {
            Char.transform.position = new Vector3(-0.68f, 8.49f, 1.51f);
        }


    }
}
