using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject textinfo;
    public GameObject panel;
    public GameObject textinfo2;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    private Animator _animator;

    public static bool GameIsPaused = false;

    void Start()
    {
        textinfo.gameObject.SetActive(false);
        textinfo2.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);

        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                textinfo.gameObject.SetActive(true);
                panel.gameObject.SetActive(false);
                Resume();
            }
            else
            {
                textinfo2.gameObject.SetActive(true);
                panel.gameObject.SetActive(false);
                Resume();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            textinfo.gameObject.SetActive(true);
        }
        else
        {
            textinfo2.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            panel.gameObject.SetActive(true);
            textinfo.gameObject.SetActive(false);
            Pause();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            panel.gameObject.SetActive(true);
            textinfo2.gameObject.SetActive(false);
            Pause();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenDoor();
            textinfo.gameObject.SetActive(false);
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
        else
        {
            textinfo2.gameObject.SetActive(false);
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
}