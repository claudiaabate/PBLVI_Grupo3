using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoor : MonoBehaviour
{
    public KeyCode OpenKeyCode;

    public float OpenPosition;
    public float ClosePosition;
    public float Duration =1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShoulOpen())
        {
            OpenDoor();
        }
    }

    public void OpenDoor()
    {
        StartCoroutine(OpenSmoothly());
        
    }

    IEnumerator OpenSmoothly()
    {
        float x = transform.position.x;
        float y = OpenPosition;
        float z = transform.position.z;

        float t = 0;
        while (t < Duration)
        {
            t += Time.deltaTime;

            y = Mathf.Lerp(ClosePosition, OpenPosition, t / Duration);
            transform.position = new Vector3(x, y, z);
            yield return null;
        }
    }

    private bool ShoulOpen()
    {
        return Input.GetButtonDown("Open");
    }
}
