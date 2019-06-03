using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaHorus : MonoBehaviour
{
    public GameObject _monedaHorus;
    public GameObject _ImonedaHorus;

    public GameObject _textMonedas;
    public GameObject trigger;

    void Start()
    {
        _ImonedaHorus.SetActive(false);
        _textMonedas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        _monedaHorus.SetActive(false);

        _textMonedas.SetActive(true);
        StartCoroutine(WaitTime());

        _ImonedaHorus.SetActive(true);

        trigger.SetActive(false);
    }


    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(4f);
        _textMonedas.SetActive(false);
    }
}
