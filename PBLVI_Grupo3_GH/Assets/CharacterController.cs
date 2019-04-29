using UnityEngine;

namespace Arkanoid
{
    public class CharacterController : MonoBehaviour
    {
        public float speed = 2f; //la f al lado del 2 indica que es float
        public UnityEngine.CharacterController charController;

        // Update is called once per frame
        void Update()
        {
            //Mirar en project settings (Unity)
            float horizontal = Input.GetAxis("Horizontal");
            Debug.Log("horizontal: " + horizontal);

            float vertical = Input.GetAxis("Vertical");
            Debug.Log("vertical: " + horizontal);

            Vector3 velocity = new Vector3(horizontal, 0, vertical);
            Debug.Log("velocity: " + velocity);

            Debug.Log("-------------------------------------------");

            velocity = speed * velocity;

            charController.SimpleMove(velocity);
        }
    }
}