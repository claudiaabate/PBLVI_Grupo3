using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 2f;
    public UnityEngine.CharacterController charController;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(horizontal, 0, vertical);

        velocity = speed * velocity;

        charController.SimpleMove(velocity);
    }
}