using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject camera_general;
    public GameObject camera_detail;
    public GameObject text;
    public GameObject text2;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        text.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            camera_general.gameObject.SetActive(true);
            camera_detail.gameObject.SetActive(false);

            text2.gameObject.SetActive(false);
        }
    }

    /*public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            camera_general.gameObject.SetActive(false);
            camera_detail.gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            camera_general.gameObject.SetActive(true);
            camera_detail.gameObject.SetActive(false);
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            /*camera_general.gameObject.SetActive(false);
            camera_detail.gameObject.SetActive(true);*/

            text.gameObject.SetActive(true);
        }
    }

    // stayCount allows the OnTriggerStay to be displayed less often
    // than it actually occurs.
    private float stayCount = 0.0f;
    private void OnTriggerStay(Collider other)
    {
        /*if (stay)
        {
            /*if (stayCount > 0.25f)
            {
                Debug.Log("staying");
                stayCount = stayCount - 0.25f;
            }
            else
            {
                stayCount = stayCount + Time.deltaTime;
            }*/

            if (Input.GetKeyDown(KeyCode.L))
            {
                camera_general.gameObject.SetActive(false);
                camera_detail.gameObject.SetActive(true);

                text.gameObject.SetActive(false);
                text2.gameObject.SetActive(true);
            }
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            text.gameObject.SetActive(false);
        }
    }
}