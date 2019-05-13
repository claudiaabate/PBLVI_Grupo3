using UnityEngine;
using System.Collections;

public class RotacionCamara : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 0.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    float m_FieldOfView;

    void Start()
    {
        m_FieldOfView = 60.0f;
        Camera.main.fieldOfView = m_FieldOfView;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse2))
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");
        }

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.fieldOfView > 60)
            {
                Camera.main.fieldOfView = Camera.main.fieldOfView - 5;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView < 90)
            {
                Camera.main.fieldOfView = Camera.main.fieldOfView + 5;
            }
        }
    }
}