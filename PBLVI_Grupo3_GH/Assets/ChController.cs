using UnityEngine;

namespace Arkanoid
{
    public class ChController : MonoBehaviour
    {
        public float speed = 2f; //la f al lado del 2 indica que es float
        public UnityEngine.CharacterController charController;

        // Update is called once per frame
        void Update()
        {
            //Mirar en project settings (Unity)
            float horizontal = Input.GetAxis("Horizontal");

            float vertical = Input.GetAxis("Vertical");

            Vector3 velocity = new Vector3(horizontal, 0, vertical);

            velocity = speed * velocity;

            charController.SimpleMove(velocity);
        }
    }
}