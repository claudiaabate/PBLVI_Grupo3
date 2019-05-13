using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody rb;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera mainCamera;

    private Animator animator = null;
    public bool playerInteractuando = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float ejeH = Input.GetAxis("Horizontal");
        float ejeV = Input.GetAxis("Vertical");

        moveInput = new Vector3(ejeH, 0f, ejeV);

        Vector3 cameraForward = mainCamera.transform.forward;
        cameraForward.y = 0;

        Quaternion cameraRelativeRotation = Quaternion.FromToRotation(Vector3.forward, cameraForward);
        Vector3 lookToward = cameraRelativeRotation * moveInput;

        if (moveInput.sqrMagnitude > 0)
        {
            Ray lookRay = new Ray(transform.position, lookToward);
            transform.LookAt(lookRay.GetPoint(1));
        }

        moveVelocity = transform.forward * speed * moveInput.sqrMagnitude;

        Animating();
    }

    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }

    void Animating()
    {
        animator.SetFloat("blendSpeed", rb.velocity.magnitude);
    }
}
