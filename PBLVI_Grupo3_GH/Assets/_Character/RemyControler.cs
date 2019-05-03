using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyControler : MonoBehaviour
{
    public GameObject camera_main = null;

    public float speed = 2.0f;

    private Vector3 direction = Vector3.zero;
    private Vector3 movement = Vector3.zero;
    private Vector3 perpendicular = Vector3.zero;

    private Animator animator = null;

    // Start is called before the first frame update
    void Start()
    {
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
            animator.SetBool("is_moving", true);

            double targetDegrees = Mathf.Atan2(movement.x, movement.z) * 57.29577;
            transform.rotation = Quaternion.AngleAxis((float)targetDegrees, Vector3.up);
        }
        else
        {
            animator.SetBool("is_moving", false);
        }
    }
}
