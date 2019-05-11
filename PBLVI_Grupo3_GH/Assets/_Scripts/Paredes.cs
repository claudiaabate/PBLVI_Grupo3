using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes : MonoBehaviour
{
    
    private Animator _animator2;

    
    public GameObject pared2;

    public bool exit = true;

    void Start()
    {
        
        pared2.SetActive(false);

        
        _animator2 = pared2.GetComponent<Animator>();
    }


    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            
            pared2.SetActive(true);

            
            _animator2.SetBool("Cierre2", true);
        }

    }
}
