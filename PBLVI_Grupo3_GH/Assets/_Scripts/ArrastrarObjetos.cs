using UnityEngine;

public class ArrastrarObjetos : MonoBehaviour
{
    public GameObject ui;
    public float speed = 2f;
    public float peso = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ui.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            float horizontal = Input.GetAxis("Horizontal");

            float vertical = Input.GetAxis("Vertical");

            Vector3 velocity = new Vector3(horizontal, 0, vertical);

            if (Input.GetKey(KeyCode.F))
            {
                other.gameObject.GetComponent<RemyControler>().playerInteractuando = true;
                velocity = speed * velocity;
                transform.position += velocity * Time.deltaTime;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ui.SetActive(false);
            other.gameObject.GetComponent<RemyControler>().playerInteractuando = false;
        }
    }
}
