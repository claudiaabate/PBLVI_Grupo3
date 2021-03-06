﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyControler : MonoBehaviour
{
    public GameObject camera_main = null;

    public float speed = 2.0f;

    private Vector3 direction = Vector3.zero;
    private Vector3 movement = Vector3.zero;
    private Vector3 perpendicular = Vector3.zero;
    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Rigidbody rb;
    private Animator animator = null;
    public bool playerInteractuando = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;

        direction = (transform.position - camera_main.transform.position).normalized;

        perpendicular = Vector3.Cross(transform.up, camera_main.transform.position).normalized;

        if (Input.GetKey(KeyCode.W))
        {
            movement += direction * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement -= direction * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement += perpendicular * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement -= perpendicular * speed;
        }

        if (movement != Vector3.zero)
        {
            movement *= Time.deltaTime;
            movement.y = 0;
            transform.position += movement;
            //animator.SetBool("is_moving", true);

            //animator.SetFloat("blendSpeed", rb.velocity.magnitude);
            animator.SetFloat("blendSpeed", 1);

            if (movement.sqrMagnitude > 0 && playerInteractuando == false)
            {
                double targetDegrees = Mathf.Atan2(movement.x, movement.z) * 57.29577;
                transform.rotation = Quaternion.AngleAxis((float)targetDegrees, Vector3.up);
            }
        }
        
        else
        {
            //animator.SetBool("is_moving", false);
            animator.SetFloat("blendSpeed", 0);
        }

        //moveVelocity = transform.forward * speed * movement.sqrMagnitude;

        //Animating();
    }
    /*
    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }

    void Animating()
    {
        animator.SetFloat("blendSpeed", rb.velocity.magnitude);
    }
    */
}
