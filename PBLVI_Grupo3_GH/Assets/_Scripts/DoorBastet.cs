﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DoorBastet : MonoBehaviour
{
    AudioSource audioData;
    public AudioClip info;

    public GameObject textinfo;
    public GameObject panel;
    //public GameObject textinfo2;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    //public Animator _animator;

    public static bool GameIsPaused = false;

    void Start()
    {
        textinfo.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);

        audioData = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (panel.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            Salir();
        }
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
            panel.gameObject.SetActive(true);
            textinfo.gameObject.SetActive(false);
            Pause();
            audioData.PlayOneShot(info);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            textinfo.gameObject.SetActive(false);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Salir()
    {
            panel.gameObject.SetActive(false);
            textinfo.gameObject.SetActive(true);
            Resume();
    }
}