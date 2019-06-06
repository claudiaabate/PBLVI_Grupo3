using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedaRa : Inventario
{ 
    public GameObject _monedaRa;
    public GameObject trigger;

    public GameObject sound;
    AudioSource audioData;
    public AudioClip recogerRa;

    void Start()
    {
        _ImonedaRa.SetActive(false);
        _textMonedas.SetActive(false);

        audioData = sound.GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioData.PlayOneShot(recogerRa);

            _monedaRa.SetActive(false);

            _textMonedas.SetActive(true);
            StartCoroutine(WaitTime());

            _ImonedaRa.SetActive(true);
            trigger.SetActive(false);
        }
    }


    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(4f);
        _textMonedas.SetActive(false);
    }
}
