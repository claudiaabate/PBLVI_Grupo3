using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject camera_general;
    public GameObject camera_detail;
    public GameObject text_enter;
    public GameObject text_exit;
    public GameObject person;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        text_enter.gameObject.SetActive(false);
        text_exit.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            camera_general.gameObject.SetActive(true);
            camera_detail.gameObject.SetActive(false);

            text_exit.gameObject.SetActive(false);
            person.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            text_enter.gameObject.SetActive(true);
        }
    }

    // stayCount allows the OnTriggerStay to be displayed less often
    // than it actually occurs.
    //private float stayCount = 0.0f;
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

            if (Input.GetKeyDown(KeyCode.Z))
            {
                camera_general.gameObject.SetActive(false);
                camera_detail.gameObject.SetActive(true);

                text_enter.gameObject.SetActive(false);
                text_exit.gameObject.SetActive(true);

                person.gameObject.SetActive(false);
            }
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            text_enter.gameObject.SetActive(false);
        }
    }
}