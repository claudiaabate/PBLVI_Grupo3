using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject textinfo;
    public GameObject textopen;
    public GameObject ra;
    public GameObject horus;
    public GameObject bastet;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        textinfo.gameObject.SetActive(false);
        textopen.gameObject.SetActive(false);
        ra.gameObject.SetActive(false);
        horus.gameObject.SetActive(false);
        bastet.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ra.gameObject.SetActive(false);
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
            textinfo.gameObject.SetActive(true);
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

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ra.gameObject.SetActive(false);
                textinfo.gameObject.SetActive(true);
            }
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            textinfo.gameObject.SetActive(false);
        }
    }
}