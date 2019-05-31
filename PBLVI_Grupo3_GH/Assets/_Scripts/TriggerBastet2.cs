using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TriggerBastet2 : MonoBehaviour
{
    AudioSource audioData;
    public AudioClip snd_effect;


    public GameObject textinfo;
    public GameObject puzzle2Bastet;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    public static bool GameIsPaused = false;

    void Start()
    {
        textinfo.gameObject.SetActive(false);
        puzzle2Bastet.gameObject.SetActive(false);

        audioData = GetComponent<AudioSource>();
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            textinfo.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            textinfo.gameObject.SetActive(false);
            puzzle2Bastet.gameObject.SetActive(true);
            audioData.PlayOneShot(snd_effect);
            //Pause();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            textinfo.gameObject.SetActive(false);
        }
    }

    /*public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }*/
}
