using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRa : MonoBehaviour
{
    public GameObject textinfo;
    public GameObject panel;
    //public GameObject textinfo2;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    public Animator _animator;
    public GameObject RaPuerta;

    public static bool GameIsPaused = false;

    void Start()
    {
        textinfo.gameObject.SetActive(false);
        //textinfo2.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);

        _animator = RaPuerta.GetComponent<Animator>();
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            panel.gameObject.SetActive(true);
            textinfo.gameObject.SetActive(false);
            Pause();
            //Salir();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenDoor();
            textinfo.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            textinfo.gameObject.SetActive(false);
        }
    }

    public void OpenDoor()
    {
        _animator.SetBool("ShouldOpen", true);
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
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
            panel.gameObject.SetActive(false);
            textinfo.gameObject.SetActive(true);
            Resume();
        //}
    }
}