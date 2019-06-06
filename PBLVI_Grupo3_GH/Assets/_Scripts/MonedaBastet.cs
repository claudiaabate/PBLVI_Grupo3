using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaBastet : Inventario
{
    public GameObject _monedaBastet;

    public GameObject trigger;

    public GameObject sound;
    AudioSource audioData;
    public AudioClip recogerBastet;

    void Start()
    {
        _ImonedaBastet.SetActive(false);
        _textMonedas.SetActive(false);

        audioData = sound.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            audioData.PlayOneShot(recogerBastet);

            _monedaBastet.SetActive(false);

            _textMonedas.SetActive(true);
            StartCoroutine(WaitTime());

            _ImonedaBastet.SetActive(true);

            trigger.SetActive(false);
        }
        
    }


    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(4f);
        _textMonedas.SetActive(false);
    }
}
