using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedaHorus : Inventario
{
    public GameObject _monedaHorus;

    public GameObject trigger;

    public GameObject sound;
    AudioSource audioData;
    public AudioClip recogerHorus;

    void Start()
    {
        _ImonedaHorus.SetActive(false);
        _textMonedas.SetActive(false);

        audioData = sound.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioData.PlayOneShot(recogerHorus);

            _monedaHorus.SetActive(false);

            _textMonedas.SetActive(true);
            StartCoroutine(WaitTime());

            _ImonedaHorus.SetActive(true);
            trigger.SetActive(false);
        }
       
    }


    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(4f);
        _textMonedas.SetActive(false);
    }
}
