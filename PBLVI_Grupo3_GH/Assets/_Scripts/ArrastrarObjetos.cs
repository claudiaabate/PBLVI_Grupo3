using UnityEngine;

public class ArrastrarObjetos : MonoBehaviour
{
    public GameObject ui;
    public float speed = 2f;

    private void OnTriggerEnter(Collider other)
    {
        ui.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        float vertical = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(horizontal, 0, vertical);

        if (Input.GetKey(KeyCode.F))
        {
            velocity = speed * velocity;
            transform.position += velocity * Time.deltaTime;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
    }
}
