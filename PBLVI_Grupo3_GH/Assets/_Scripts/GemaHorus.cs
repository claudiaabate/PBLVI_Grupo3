using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemaHorus : Gemas
{
    public float PesoCorrecto = 6f;
    private float PesoPuzzle = 0f;

    public GameObject _esconditeHorus;

    private Animator _animator;

    //public GameObject camera_principal;
    public GameObject camera_gemaHorus;

    public GameObject Person;

    bool first = true;

    public GameObject sound;
    AudioSource audioData2;
    public AudioClip escondite;


    void Start()
    {
        _animator = _esconditeHorus.GetComponent<Animator>();
        audioData2 = sound.GetComponent<AudioSource>();
    }

    private void Update()
    {
        Solución();
    }

    private void Solución()
    {
        PesoPuzzle = gameObject.GetComponentInParent<PuzzlePesos>().pesoTotal;

        if(PesoCorrecto == PesoPuzzle)
        {
            _animator.SetBool("Up", true);
            

            if (first)
            {
                audioData2.PlayOneShot(escondite);
                StartCoroutine(WaitTime2());
                first = false;
            }
            /*camera_principal.gameObject.SetActive(false);
            camera_gemaHorus.gameObject.SetActive(true);
            Person.gameObject.SetActive(false);*/
        }
    }

    IEnumerator WaitTime2()
    {
        camera_principal.gameObject.SetActive(false);
        camera_gemaHorus.gameObject.SetActive(true);
        Person.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        camera_principal.gameObject.SetActive(true);
        camera_gemaHorus.gameObject.SetActive(false);
        Person.gameObject.SetActive(true);
    }
}
