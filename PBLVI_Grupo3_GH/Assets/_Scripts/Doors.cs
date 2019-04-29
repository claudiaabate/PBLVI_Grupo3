using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject textinfo;
    public GameObject ra;
    public GameObject horus;
    public GameObject bastet;

    public bool enter = true;
    public bool stay = true;
    public bool exit = true;
    public float moveSpeed;

    private Animator _animator;
    //public float OpenPosition;
    //public float ClosePosition;
    //public float Duration = 1;

    // Start is called before the first frame update
    void Start()
    {
        textinfo.gameObject.SetActive(false);
        ra.gameObject.SetActive(false);
        horus.gameObject.SetActive(false);
        bastet.gameObject.SetActive(false);

        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ra.gameObject.SetActive(true);
            textinfo.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            horus.gameObject.SetActive(true);
            textinfo.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            bastet.gameObject.SetActive(true);
            textinfo.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenDoor();
            textinfo.gameObject.SetActive(false);
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
    //private float stayCount = 0.0f;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ra.gameObject.SetActive(false);
            horus.gameObject.SetActive(false);
            bastet.gameObject.SetActive(false);
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
        //StartCoroutine(OpenSmoothly());
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 1000, 0), 2 * Time.deltaTime);
        //Quaternion rotation = Quaternion.Euler(0, 30, 0);
        _animator.SetBool("ShouldOpen", true);
    }

    /*IEnumerator OpenSmoothly()
    {
        float x = transform.rotation.x;
        float y = OpenPosition;
        float z = transform.rotation.z;

        float t = 0;
        while (t < Duration)
        {
            t += Time.deltaTime;

            y = Mathf.Lerp(ClosePosition, OpenPosition, t / Duration);
            //transform.position = new Vector3(x, y, z);
            Quaternion rotation = Quaternion.Euler(x, y, z);
            yield return null;
        }
    }*/
}